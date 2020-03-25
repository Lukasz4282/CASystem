using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Management
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbSelect.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdLecturer.Checked)
            {
                Form newForm = new frmLect();
                newForm.Show();
            }

            else if (rdStudent.Checked)
            {
                Form newForm = new frmStudent();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Please select either Student Option Or Lecturer Option");
            }
        }

        private void rdStudent_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private void rdLecturer_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
