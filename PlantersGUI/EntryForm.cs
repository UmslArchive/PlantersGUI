using System;
using System.Windows.Forms;

namespace PlantersGUI
{
    public partial class EntryForm : Form
    {
        //Declare forms which can be navigated to from "EntryForm".
        public static SetupForm setupForm = new SetupForm();
        public static ContinueForm continueForm = new ContinueForm();

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntrySetupButton_Click(object sender, EventArgs e)
        {
            //Switch to "SetupForm".
            this.Visible = false;
            setupForm.Visible = true;
        }

        private void EntryContinueButton_Click(object sender, EventArgs e)
        {
            //Switch to "ContinueForm".
            this.Visible = false;
            continueForm.Visible = true;
        }
    }
}
