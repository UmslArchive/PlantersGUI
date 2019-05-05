using System;
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
        public ContinueForm()
        {
            InitializeComponent();
        }

        private void DeviceMonitorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ContinueForm_Load(object sender, EventArgs e)
        {
            //Load tables into tablesComboBox.
            foreach(Table table in Program.exp.tables)
            {
                tablesComboBox.Items.Add(table.title);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.entryForm.Show();
        }

        private void TablesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void ConstructDataGrid()
        {
            //Get selected table's index.
            int selectedTableIndex = -1;
            foreach(Table table in Program.exp.tables)
                if (table.title == tablesComboBox.GetItemText(tablesComboBox.SelectedItem))
                    selectedTableIndex = Program.exp.tables.IndexOf(table);

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


                //Add data to DataGrid.
                string[] headerRow =
                    {   Program.exp.tables[selectedTableIndex].indepVariable,
                    Program.exp.tables[selectedTableIndex].depVariable      };
            }
        }

        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TablesComboBox_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void TablesComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ConstructDataGrid();
        }
    }
}
