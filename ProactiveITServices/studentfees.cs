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


namespace ProactiveITServices
{
    public partial class studentfees : Form
    {
        public studentfees()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");

        private void studentfees_Load(object sender, EventArgs e)
        {


        }

        private void txtid_OnTextChange(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void txtourses_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtourses_Enter(object sender, EventArgs e)
        {


        }

        private void txtourses_KeyDown(object sender, EventArgs e)
        {


        }

        private void txtfees_OnTextChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtourses.text == "")
                {
                    lblid.Text = "Course Field is blank";
                }
                else
                {


                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT * FROM crs1 where course_name='" + txtourses.text + "' ", cn);
                    //  @" SELECT * FROM Images where id = @id
                    DataTable dt = new DataTable();
                    cn.Close();
                    cn.Open();
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        txtfees.text = (myReader["fess"].ToString());
                        //                  lblid.Text = "Select !";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong !");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        private void txtourses_KeyPress(object sender, EventArgs e)
        {

        }

        private void txtourses_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtid.text == "")
                {
                    lblid.Text = "Student Id Is blank !";
                }
                else
                {

                    StudentReg std = new StudentReg();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT * FROM stdreg where studen_id='" + txtid.text + "' ", cn);
                    //  @" SELECT * FROM Images where id = @id
                    cn.Close();
                    cn.Open();
                    myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        txtname.text = (myReader["name"].ToString());
                        txtsurname.text = (myReader["surname"].ToString());
                        mrktxtcontct.Text = (myReader["contact"].ToString());
                        txtourses.text = (myReader["course"].ToString());
                        cmbduration.Text = (myReader["duration"].ToString());
                        cmbmoth.Text = (myReader["moth"].ToString());
                        mrktxtdate.Text = (myReader["jdate"].ToString());

                        button1_Click(sender, e);
                        lblid.Text = "Record Found";
                    }
                    else
                    {
                        lblid.Text = "Not Found";
                    }

                }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong !");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblid.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtid.text == "")
                {

                    MessageBox.Show("Insert Student id And Fetch Data");
                }
                else
                {
                    SqlCommand cmd;
                    string qry = "insert into stdfees(studen_id,course_name,pfees,pdate,rmfees,payfees) values('" + txtid.text + "','" + txtourses.text + "','" + txtfees.text + "','" + mrktxtpdat.Text + "','" + txtrmfees.text + "','" + txtrmfees.text + "')";

                    cmd = new SqlCommand(qry, cn);
                    cn.Close();
                    cn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        //   Form1_Load(sender,e);
                        //  course_Load(sender, e);
                        MessageBox.Show("Insert Successfully");
                        txtname.text=string.Empty;
                        txtsurname.text=string.Empty;
                        mrktxtcontct.Text=string.Empty;
                        cmbduration.SelectedIndex = 0;
                        cmbmoth.SelectedIndex = 0;
                         txtid.text=string.Empty;
                         txtourses.text=string.Empty;
                         txtfees.text = string.Empty;
                          mrktxtpdat.Text=string.Empty;
                         txtrmfees.text=string.Empty;
                         txtrmfees.text=string.Empty;
                         paidfees.text = string.Empty;
                         mrktxtdate.Text = string.Empty;
                       linkLabel1.Visible = false;
                       // btnupdate.Visible=false
                    }
                    else
                    {
                        MessageBox.Show("Failed to Insert");
                    }
                    cn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void txtrmfees_OnTextChange(object sender, EventArgs e)
        {
            //txtrmfees.text = Convert.ToDouble(txtfees.text) -Convert.ToDouble(txtpfees.text).ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update stdfees set studen_id='" + txtid.text + "',course_name='" + txtourses.text + "',pfees='" + txtfees.text + "',pdate='" + mrktxtpdat.Text + "',rmfees='" + txtrmfees.text + "',payfees='" + paidfees.text + "'  where studen_id='" + txtid.text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);
                cn.Close();
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    // course_Load(sender, e);
                    MessageBox.Show("update Successfully");
                    txtname.text = string.Empty;
                    txtsurname.text = string.Empty;
                    mrktxtcontct.Text = string.Empty;
                    cmbduration.SelectedIndex = 0;
                    cmbmoth.SelectedIndex = 0;
                    txtid.text = string.Empty;
                    txtourses.text = string.Empty;
                    txtfees.text = string.Empty;
                    mrktxtpdat.Text = string.Empty;
                    txtrmfees.text = string.Empty;
                    txtrmfees.text = string.Empty;
                    paidfees.text = string.Empty;
                    mrktxtdate.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void txtrmfees_OnTextChange_1(object sender, EventArgs e)
        {

        }

        private void txtpfees_OnTextChange(object sender, EventArgs e)
        {



            double a, b, c;

            double.TryParse(txtfees.text, out a);
            double.TryParse(paidfees.text, out b);
            if (b > a)
            {
                txtrmfees.text = "ERROR";
            }
            c = a - b;
            if (c > 0)
                txtrmfees.text = c.ToString("c").Remove(0, 1);
        }

        internal void linkLabel1_LinkClicked(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


        }

        private void btview_Click(object sender, EventArgs e)
        {
            fees fs = new fees();
            this.Visible = false;
            fs.ShowDialog();
         
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnlbldate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnlbldate_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mrktxtpdat.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnstddata_Click(object sender, EventArgs e)
        {
            if (txtid.text == "")
            {
                frmstdview frrmview = new frmstdview();
                this.Visible = false;
                frrmview.ShowDialog();
                

            }
            else
            {
                lblid.Text = "Student-id Selected !";
            }
           

          
        }

        private void studentfees_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
    

