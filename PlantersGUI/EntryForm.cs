using System;
using System.Windows.Forms;

namespace PlantersGUI
{
    public partial class EntryForm : Form
    {
        //Declare forms which can be navigated to from "EntryForm".
        public static SetupForm setupForm;
        public static ContinueForm continueForm;

        public EntryForm()
        {
            InitializeComponent();

            //Initialize experiment.
            Program.exp = new Experiment();
        }

        private void EntrySetupButton_Click(object sender, EventArgs e)
        {
            //Switch to "SetupForm".
            this.Visible = false;
            setupForm = new SetupForm();
            setupForm.Show();
        }

        private void EntryContinueButton_Click(object sender, EventArgs e)
        {
            //Switch to "ContinueForm".
            this.Visible = false;
            continueForm = new ContinueForm();
            continueForm.Show();
        }

        private void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
