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
    }
}
