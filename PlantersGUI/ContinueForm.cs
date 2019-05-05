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
    }
}
