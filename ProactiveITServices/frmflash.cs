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
    public partial class frmflash : Form
    {
        public frmflash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 386)
            {
                timer1.Start();
                this.Visible = false;
                frmlogin frmlogin = new frmlogin();
                timer1.Stop();
              frmlogin.ShowDialog();
            }

        }

        private void frmflash_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://");  
        }
    }
}
