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
    public partial class frmCA : Form
    {
        public frmCA()
        {
            InitializeComponent();
            cbCAOptions.SelectedIndex = 0;
        }

        private void frmCA_Load(object sender, EventArgs e)
        {

        }

        private void cbCAOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCAOptions.SelectedIndex==0)
            {
                btnSubmitCA.Text = "ADD CA";
            }
            else if (cbCAOptions.SelectedIndex == 1)
            {
                btnSubmitCA.Text = "EDIT CA";
            }
            else
            {
                btnSubmitCA.Text = "DELETE CA";
                dtDueDate.Enabled = false;
                numPercentage.Enabled = false;
            }
        }
    }
}
