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
    public partial class TableConfigForm : Form
    {
        public TableConfigForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //Create a new table with user input as parameters and add it to the list of tables contained in exp.
            Program.exp.tables.Add(new Table(titleTextBox.Text, indepVarComboBox.Text, depVarComboBox.Text, dffNumericUpDown.Value));
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Function resets all textboxes, etc.
        private void ResetForm()
        {
            titleTextBox.Clear();
        }

        private void TableConfigForm_Load(object sender, EventArgs e)
        {
            this.ResetForm();
        }
    }
}
