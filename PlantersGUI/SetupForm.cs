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
    public partial class SetupForm : Form
    {
        //Declare forms which are possible to navigate from "SetupForm">
        public static ContinueForm continueForm;
        public static TableConfigForm tableConfigForm;

        public SetupForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Switch to "EntryForm".
            Close();
            Program.entryForm.Show();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Switch to "ContinueForm".
            Close();
            continueForm = new ContinueForm();
            continueForm.Show();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            //Show "TableConfigForm" as dialog window.
            tableConfigForm = new TableConfigForm();
            tableConfigForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Show "TableConfigForm" as dialog window.
            tableConfigForm = new TableConfigForm();
            tableConfigForm.ShowDialog();
        }

        //On form focus, refresh the table list.
        private void SetupForm_Activated(object sender, EventArgs e)
        {
            //Clear the list of tables.
            tablesListBox.Items.Clear();

            //Add each table to the list of items.
            foreach(Table table in Program.exp.tables)
                tablesListBox.Items.Add(table.title);
        }

        private void RemoveTableButton_Click(object sender, EventArgs e)
        {
            //Iterate through list of tables until a match with selected is found and remove from tables list.
            if (tablesListBox.SelectedItem != null) 
            {
                int index = -1;
                foreach (Table table in Program.exp.tables)
                    if (tablesListBox.SelectedItem.ToString() == table.title.ToString())
                        index = Program.exp.tables.IndexOf(table);

                if (index > -1)
                    Program.exp.tables.RemoveAt(index);
            }

            //Remove table item from listbox.
            tablesListBox.Items.Remove(tablesListBox.SelectedItem);
        }

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            //Initialize a device object.
            Program.exp.devices.Add(new Device(deviceComboBox.Text, variableTextBox.Text, valueNumericUpDown.Value, inequalityComboBox.Text));

            //Clear the comboBox.
            deviceComboBox.Items.Clear();

            //Add devices to the combobox.
            foreach (Device device in Program.exp.devices)
                deviceComboBox.Items.Add(device.id);
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            //TODO: Populate deviceComboBox with devices. (arduino sensors)
        }
    }
}
