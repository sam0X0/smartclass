using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProactiveITServices
{
    public partial class softsetup : Form
    {
        public softsetup()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnsetup_Click(object sender, EventArgs e)
        {
            frmsetup setup = new frmsetup();
            setup.ShowDialog();
            // this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbkp_Click(object sender, EventArgs e)
        {
            frmback backup = new frmback();
            backup.ShowDialog();
            //  this.Close();
        }
    }
}
