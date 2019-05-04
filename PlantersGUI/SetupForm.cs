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
        public static EntryForm entryForm = new EntryForm();
        public static ContinueForm continueForm = new ContinueForm();
        public static TableConfigForm tableConfigForm = new TableConfigForm();

        public SetupForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Switch to "EntryForm".
            this.Visible = false;
            entryForm.Show();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Switch to "ContinueForm".
            this.Visible = false;
            continueForm.Show();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            //Show "TableConfigForm" as dialog window.
            tableConfigForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Show "TableConfigForm" as dialog window.
            tableConfigForm.ShowDialog();
        }

        //On form focus.
        private void SetupForm_Activated(object sender, EventArgs e)
        {
            //Update tablesListBox of tables.
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
    }
}
