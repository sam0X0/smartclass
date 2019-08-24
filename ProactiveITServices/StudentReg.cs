using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading;


namespace ProactiveITServices
{

    public partial class StudentReg : Form
    {

        public StudentReg()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cmbmoth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnlbldate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mrktxtdate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblvissible_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnaddcourse_Click(object sender, EventArgs e)
        {

        }

        private void txtid_OnTextChange(object sender, EventArgs e)
        {
            
        }
            

        private void btnsave_Click(object sender, EventArgs e)
        {
           // SqlCommand query;
            try
            {
                if (mrktxtcontct.Text.Length <=13)
                {

                    MessageBox.Show("Please enter Conatact Number");
                }
           
               
                else
                {


                    int i = 0;
                    cn.Close();
                    cn.Open();
                 
                   SqlCommand cmd = new SqlCommand("insert into stdreg (name,surname,dob,gender,contact,address,course,duration,moth,jdate,email) values('" + txtname.text + "','" + txtsurname.text + "','" + mrktxtdate.Text + "','" + cmbgender.Text + "','" + mrktxtcontct.Text + "','" + txtadd.Text + "','" + txtourses.text + "','" + cmbduration.Text + "','" + cmbmoth.Text + "','" + mrktxtdate.Text + "','" + txtemail.text + "')", cn);
                  
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                   {
                        MessageBox.Show("Student Id genrate Successfully !");
                        txtname.text = string.Empty;
                        txtsurname.text = string.Empty;
                        mrktxtdob.Text = string.Empty;
                        cmbgender.SelectedIndex = 0;
                        mrktxtcontct.Text = string.Empty;
                        txtadd.Text = string.Empty;
                        txtourses.text = string.Empty;
                        cmbduration.SelectedIndex = 0;
                        cmbmoth.SelectedIndex = 0;
                        mrktxtdate.Text = string.Empty;
                        txtemail.text = string.Empty;
                    }
                   
                }
            }
            catch
            {
                if (mrktxtcontct.Text.Length <= 10)
                {

                    MessageBox.Show("Please enter Conatact Number");
                }
                else
                {
                    cn.Close();
                    int i = 0;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into stdreg (name,surname,dob,gender,contact,address,course,duration,moth,jdate,email) values('" + txtname.text + "','" + txtsurname.text + "','" + mrktxtdate.Text + "','" + cmbgender.Text + "','" + mrktxtcontct.Text + "','" + txtadd.Text + "','" + txtourses.text + "','" + cmbduration.Text + "','" + cmbmoth.Text + "','" + mrktxtdate.Text + "','" + txtemail.text + "')", cn);
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Student Id genrate Successfully !");
                        txtname.text = string.Empty;
                        txtsurname.text = string.Empty;
                        mrktxtdob.Text = string.Empty;
                        cmbgender.SelectedIndex = 0;
                        mrktxtcontct.Text = string.Empty;
                        txtadd.Text = string.Empty;
                        txtourses.text = string.Empty;
                        cmbduration.SelectedIndex = 0;
                        cmbmoth.SelectedIndex = 0;
                        mrktxtdate.Text = string.Empty;
                        txtemail.text = string.Empty;
                    
                    }

                }
            }
        }


        private void StudentReg_Load(object sender, EventArgs e)
        {
            
            if (txtourses.text == "")
            {
                lblid.Text = "Enter Course id or Course Name  ! ";
            }
            timer1.Start();
            timer1.Enabled = true;
            
            cn.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(@"SELECT * FROM stdreg ", cn);
            //  @" SELECT * FROM Images where id = @id

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtid.text = (myReader["studen_id"].ToString());

            }
            cn.Close();
            myReader.Close();
           

            


        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            
            view viewas = new view();
            this.Visible = false;
         
            viewas.ShowDialog();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)

        {
           
           // cn.Close();

            string qry = "update stdreg  set name='" + txtname.text + "',surname='" + txtsurname.text + "',dob='" + mrktxtdob.Text + "',gender='" + cmbgender.Text + "',contact='" + mrktxtcontct.Text + "',address='" + txtadd.Text + "',course='" + txtourses.text + "',duration='" + cmbduration.Text + "',moth='" + cmbmoth.Text + "',jdate='"+mrktxtdate.Text+"',email='" + txtemail.text + "' where studen_id='" + txtid1.text + "'";
            int i = 0;
            SqlCommand cmd = new SqlCommand(qry, cn);
            cn.Close();
            cn.Open();
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
            //    lblid.Text = "Record Updated";
               MessageBox.Show("Update successfully");
                txtname.text = string.Empty;
                txtsurname.text = string.Empty;
                mrktxtdob.Text = string.Empty;
                cmbgender.SelectedIndex = 0;
                mrktxtcontct.Text = string.Empty;
                txtadd.Text = string.Empty;
                txtourses.text = string.Empty;
                cmbduration.SelectedIndex = 0;
                cmbmoth.SelectedIndex = 0;
                mrktxtdate.Text = string.Empty;
                txtemail.text = string.Empty;
                txtid.Visible = false;
                label2.Visible = false;
            }

            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtourses_OnTextChange(object sender, EventArgs e)
        {
            if (txtourses.text == "")
            {
                button1_Click(sender, e);
            }
            if(txtrs.text=="")
            {
                txtrs.text = "";
            }
            
            
        }

        private void txtrs_OnTextChange(object sender, EventArgs e)
        {
            if (txtrs.text != null)
            {
                button1_Click(sender, e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtrs.text, "^[a-zA-z]"))
                {

                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT * FROM crs1 where course_id='" + txtrs.text + "' ", cn);
                    //  @" SELECT * FROM Images where id = @id
                    DataTable dt = new DataTable();
                    cn.Close();
                    cn.Open();
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        txtourses.text = (myReader["course_name"].ToString());
                        lblid.Text = "Select !";
                    }
                    else
                    {

                        txtourses.text = "No data OOPS";
                    }
                    if (txtourses.text == "")
                    {
                        lblid.Text = "Enter Course id or Course Name  ! ";
                        //   txtourses.text = string.Empty;
                    }



                }


                else
                {
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT * FROM crs1 where course_name='" + txtrs.text + "' ", cn);
                    //  @" SELECT * FROM Images where id = @id
                    cn.Close();
                    cn.Open();
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        txtourses.text = (myReader["course_name"].ToString());

                    }
                    if (txtourses.text == "")
                    {
                        lblid.Text = "Enter Course id or Course Name  ! ";
                        txtourses.text = string.Empty;
                    }



                    else
                    {
                        lblid.Text = "No Data OOPS !";
                    }
                }
            }
            catch 
            {
                lblid.Text = "Enter Wrong Id Or Course Name !";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(@"SELECT * FROM stdreg where studen_id='" + txtid.text + "' ", cn);
            //  @" SELECT * FROM Images where id = @id
            cn.Close();
            cn.Open();
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtourses.text = (myReader["course"].ToString());


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblid.ForeColor = Color.FromArgb(one,two,three,four);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            course crs = new course();
            crs.txtname.Enabled = false;
            crs.txtfees.Enabled = false;
            crs.txtid.Enabled = false;
            crs.btnsave.Visible = false;
            crs.btnupdate.Visible = false;
            crs.btndelete.Visible = false;
            crs.lblid.Text = "Only Search Course id & Course Name "; 
            crs.ShowDialog();
                      
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtname_OnTextChange(object sender, EventArgs e)
        {
          
         
          
        }

        private void StudentReg_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

            
    }
            
}
    



