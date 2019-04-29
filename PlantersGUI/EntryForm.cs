using System;
using System.Windows.Forms;

namespace PlantersGUI
{
    public partial class EntryForm : Form
    {
        //This declaration follows the heirarchical tree model of the project forms. (in the readme)
        SetupForm setupForm = new SetupForm();
        ContinueForm continueForm = new ContinueForm();

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntrySetupButton_Click(object sender, EventArgs e)
        {
            //Switch from "EntryForm" to "SetupForm".
            this.Visible = false;
            setupForm.Visible = true;
        }

        private void EntryContinueButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            continueForm.Visible = true;
        }
    }
}
