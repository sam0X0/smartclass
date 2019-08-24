using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace ProactiveITServices
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            softsetup setup = new softsetup();
            setup.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm");
            lblsec.Text = DateTime.Now.ToString("ss");
            lblday.Text = DateTime.Now.ToString("dddd");
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            StudentReg stdreg = new StudentReg();
        
            stdreg.ShowDialog();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(@"SELECT * FROM clssetup ", cn);
            //  @" SELECT * FROM Images where id = @id

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                lbldclss.Text = (myReader["class_name"].ToString());

            }
            cn.Close();
               
        }

        private void ntnaddcrs_Click(object sender, EventArgs e)
        {
            course crs = new course();
            crs.ShowDialog();
        }

        private void btnfees_Click(object sender, EventArgs e)
        {
            studentfees stdfees = new studentfees();
            stdfees.ShowDialog();
        }

        private void btnstdlist_Click(object sender, EventArgs e)
        {
            stdlist stdlist = new stdlist();
            stdlist.ShowDialog();
        }

        private void btnfees1_Click(object sender, EventArgs e)
        {
            frmfee frmfee = new frmfee();
            frmfee.ShowDialog();
        }

        private void btnrcpt_Click(object sender, EventArgs e)
        {
            frm2bill bill = new frm2bill();
            bill.ShowDialog();
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            frmcontact contact = new frmcontact();
            contact.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btncard_Click(object sender, EventArgs e)
        {
            frmcard card=new frmcard();
            card.ShowDialog();
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnsetup_Click(object sender, EventArgs e)
        {
           
        }

        private void btnbkp_Click(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            

        }
    }
}
