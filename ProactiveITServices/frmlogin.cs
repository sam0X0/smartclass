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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtuname_Enter(object sender, EventArgs e)
        {
            if (txtuname.Text == "User Name")
            {
                txtuname.Text = "";
            }
        }

        private void txtpwd_Enter(object sender, EventArgs e)
        {

            
            
            //txtpwd.Text = String.Empty;
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "********";
            }
        }

        private void txtuname_Leave(object sender, EventArgs e)
        {
            if (txtuname.Text == "")
            {
                txtuname.Text = "User Name";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            
            string user, pass;
            user = txtuname.Text;
            pass = txtpwd.Text;
            if (user == "admin" && pass == "admin")
            {
                txtuname.Text = "";
                txtpwd.Text = "";
                frmdashboard dsb = new frmdashboard();
                StudentReg std = new StudentReg();
                this.Visible = false;
                dsb.lblusr.Text = "Admin";
                //std.lbluser12.Text = "Admin";
                this.Visible = false;

               
                dsb.ShowDialog();               

                
            }
            else
            {
                lblcolor.Text="Invalid Username &  Password";
                lblcolor.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtpwd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblcolor.ForeColor = Color.FromArgb(one, two, three, four);


            string user, pass;
            user = txtuname.Text;
            pass = txtpwd.Text;
            if (user == "admin" && pass == "admin")
            {
                txtuname.Text = "";
                txtpwd.Text = "";
                lblcolor.Text = "Login Successfully..";
                frmdashboard dsb = new frmdashboard();
                StudentReg std = new StudentReg();
                this.Visible = false;
                dsb.lblusr.Text = "Admin";
                //std.lbluser12.Text = "Admin";
                this.Visible = false;


                dsb.ShowDialog();


            }
            else
            {
                lblcolor.Text = "Checking Credential...";
            //    lblcolor.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void txtuname_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
