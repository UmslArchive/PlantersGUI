using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace PlantersGUI
{
    public partial class ContinueForm : Form
    {
        //Port for communication to dween.
        SerialPort dween = new SerialPort("COM5", 9600);
        bool pumpActive = false;
        int waterPumped = 0;
        int mainTickCount = 0;
        int selectedTableIndex = -1;
        bool songPlayed = false;

        //Active monitor strings.
        string deviceListString = "";
        string statusListString = "";

        //Time
        Stopwatch stopWatch = new Stopwatch();
        string elapsedTime;

        //Constructor.
        public ContinueForm()
        {
            InitializeComponent();
        }

        private void ContinueForm_Load(object sender, EventArgs e)
        {
            //Load tables into tablesComboBox.
            foreach(Table table in Program.exp.tables)
            {
                tablesComboBox.Items.Add(table.title);
            }

            //Set default table. Unfortunately means that there must be a table named "moisture" in experiment.
            tablesComboBox.Text = "moisture";

            //Get moisture sensor's user variable index.
            int moistureUVIndex = -1;
            foreach(UserVariable uv in Program.exp.userVariables)
            {
                if(uv.linkedDevice.id == "Moisture Sensor")
                {
                    moistureUVIndex = Program.exp.userVariables.IndexOf(uv);
                }
            }

            //Open the port for arduino communication.
            dween.Open();

            //Get the moisture constraint.
            string moistureConstraint = Program.exp.userVariables[moistureUVIndex].constraint.Get();

            //Send to arduino.
            dween.WriteLine(moistureConstraint);

            //Initialize active monitor list strings.
            deviceListString = "Moisture Sensor\nWater Pumped";
            deviceListLabel.Text = deviceListString;
            statusListString = "";

            //Start stopWatch.
            stopWatch.Start();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.entryForm.Show();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            //Update Active Device Monitor.
            string readMoistureValue = dween.ReadLine();

            //Calculate current elapsed time and create time string.
            TimeSpan ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            //Once per second.
            if( mainTickCount != 0 && mainTickCount % 10 == 0)
            {
                //Update the tables.
                UpdateTables("moisture", elapsedTime, readMoistureValue);
                UpdateTables("pumped", elapsedTime, waterPumped.ToString());

                //Display selected table.
                DisplaySelectedTable();
            }
            

            //Convert string that is read from arduino to an integer.
            int convertedString;

            //The data the arduino sends in the first few ticks is corrupted. this is a workaround.
            if (mainTickCount > 15)
                convertedString = Int32.Parse(readMoistureValue); //could possibly use tryparse() to avoid exception.
            else
                convertedString = 669; //air
            
            //Activate the pump when the moisture level dips below user specified constraint.
            if(convertedString < Program.exp.userVariables[0].constraint.upperBound)
            {
                pumpActive = true;
            }
            else
            {
                pumpActive = false;
            }

            if (pumpActive == true)
            {
                waterPumped += 2; //based on flow rate of the pump. amount pumped is not actually measured.
            }

            //Set the labels.
            statusListString = "";
            statusListString += readMoistureValue + "\n";
            statusListString += waterPumped.ToString();
            statusListLabel.Text = statusListString;

            //Play song after enough water is pumped.
            if (!songPlayed && waterPumped > 200)
            {
                
                songPlayed = true;
            }

            //Increment main tick count.
            ++mainTickCount;
        }

        private void ContinueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close the serial port connection to the arduino.
            dween.Close();
        }

        private void UpdateTableIndex()
        {
            //Get selected table's index.
            foreach (Table table in Program.exp.tables)
            {
                if (table.title == tablesComboBox.GetItemText(tablesComboBox.SelectedItem))
                {
                    selectedTableIndex = Program.exp.tables.IndexOf(table);
                    break;
                }
                else
                    selectedTableIndex = -1;
            }

        }

        //Function places the values that are in the active monitor into the corresponding table's DataTable.
        private void UpdateTables(string tableToUpdate, string currentElapsedTime, string currentVal)
        {
            //Currently only works when creating a moisture table first then a waterpumped table after.
            if (tableToUpdate == "moisture")
                Program.exp.tables[0].AddRow(currentElapsedTime, currentVal);
            else
                Program.exp.tables[1].AddRow(currentElapsedTime, currentVal);
        }

        private void DisplaySelectedTable()
        {
            //Update the selected table index so that the correct table is displayed.
            UpdateTableIndex();

            MapTableToDataGridView();

            //Set the scroll to bottom row. Bug: user cannot scroll.
            tablesDataGrid.FirstDisplayedScrollingRowIndex = tablesDataGrid.Rows.Count - 1;

        }

        //Function Maps DataTable object contained in table class to the datagridview object of ContinueForm.
        private void MapTableToDataGridView()
        {
            BindingSource sbind = new BindingSource();
            sbind.DataSource = Program.exp.tables[selectedTableIndex].data;
            tablesDataGrid.Columns.Clear();
            tablesDataGrid.DataSource = sbind;            
        }

        private void TableExportButton_Click(object sender, EventArgs e)
        {
            UpdateTableIndex();

            Program.exp.tables[selectedTableIndex].ExportCSV(@"C:\Users\colby\Desktop\export.csv");
        }
    }
}
