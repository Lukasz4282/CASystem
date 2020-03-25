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
    public partial class frmLect : Form
    {
        public frmLect()
        {
            InitializeComponent();
            cbFunction.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbFunction.SelectedIndex == 0)
            {
                Form newForm = new frmCourse();
                newForm.Show();
            }
            else if(cbFunction.SelectedIndex==1)
            {
                Form newForm = new frmModules();
                newForm.Show();
            }
            else
            {
                Form newForm = new frmCA();
                newForm.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
