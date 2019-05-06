using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantersGUI
{
    public partial class ContinueForm : Form
    {
        //Delcare stopwatch and timespan objects.
        public Stopwatch stopwatch = new Stopwatch();

        public Random rand = new Random();

        //Integer that tracks selected table in combobox.
        private int selectedTableIndex = -1;
        private int tableTick = 0;
        private int monitorTick = 0;
        private int waterPumped = 0;

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

            tablesComboBox.SelectedItem = "hydration";

            ConstructDataGrid();

            //Start all timers and stopwatches.
            stopwatch.Start();
            tableTimer.Start();
            deviceMonitorTimer.Start();

            //Calculate elapsed timespan.
            TimeSpan ts = stopwatch.Elapsed;

            //Updates.
            UpdateTableIndex();

            //Build row.
            string[] elapsedTime = new string[2];
            if (selectedTableIndex > -1)
            {
                elapsedTime[0] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10); //time
                elapsedTime[1] = Program.exp.tables[selectedTableIndex].data[monitorTick].ToString();  //data


                //Add row.
                tablesDataGrid.Rows.Add(elapsedTime);
            }

            //Manually set device monitor lists.
            deviceListLabel.Text = "Hydration Sensor\nWater Pump";

            //Set constraints in monitor.
            constraintListLabel.Text = "";
            string constraints = "";
            foreach(UserVariable uv in Program.exp.userVariables)
            {
                constraints += uv.constraintString + "\n";
            }

            constraintListLabel.Text = constraints;
            //constraintListLabel.Text += "NULL";
            


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.entryForm.Show();
        }

        private void ConstructDataGrid()
        {
            UpdateTableIndex();

            if(selectedTableIndex != -1)
            {
                //Set the column count.
                tablesDataGrid.ColumnCount = 2;

                //Column initialization.
                tablesDataGrid.Columns[0].Name = "IndependentVariableColumn";
                tablesDataGrid.Columns[1].Name = "DependentVariableColumn";

                //Set header text.
                tablesDataGrid.Columns[0].HeaderText = Program.exp.tables[selectedTableIndex].indepVariable;
                tablesDataGrid.Columns[1].HeaderText = Program.exp.tables[selectedTableIndex].depVariable;
            }
        }

        private void TablesComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ConstructDataGrid();
            //stopwatch.Reset();
            //stopwatch.Start();
        }

        private void DeviceMonitorTimer_Tick(object sender, EventArgs e)
        {
            if (monitorTick == 0)
                ConstructDataGrid();

            //Update device status reading.
            UpdateTableIndex();
            statusListLabel.Text = Program.exp.tables[selectedTableIndex].data[monitorTick].ToString();

            //Pump status.
            if (Program.exp.tables[selectedTableIndex].data[monitorTick] > 600)
                waterPumped += 2 + rand.Next(2);

            statusListLabel.Text += "\n" + waterPumped.ToString() + "mL";
            
            ++monitorTick;
        }

        private void UpdateTableIndex()
        {
            //Get selected table's index.
            foreach (Table table in Program.exp.tables)
            {
                if (table.title == tablesComboBox.GetItemText(tablesComboBox.SelectedItem))
                    selectedTableIndex = Program.exp.tables.IndexOf(table);
                else
                    selectedTableIndex = -1;
            }
                
        }

        private void TableTimer_Tick(object sender, EventArgs e)
        {
            //Calculate elapsed timespan.
            TimeSpan ts = stopwatch.Elapsed;
            
            //Updates.
            UpdateTableIndex();

            //Build row.
            string[] elapsedTime = new string[2];
            if (selectedTableIndex > -1)
            {
                elapsedTime[0] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10); //time
                elapsedTime[1] = Program.exp.tables[selectedTableIndex].data[monitorTick].ToString();  //data


                //Add row.
                tablesDataGrid.Rows.Add(elapsedTime);
            }

            //Increment tick.
            ++tableTick;


        }
    }
}
