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
    public partial class frmsetup : Form
    {
        public frmsetup()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        private void frmsetup_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataReader myReader = null;
           SqlCommand myCommand = new SqlCommand(@"SELECT TOP 1 * FROM  clssetup", cn);
         

            //  @" SELECT * FROM Images where id = @id

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtid.text = (myReader["setup_id"].ToString());
               txtname.text = (myReader["class_name"].ToString());
               mrktxtcontct.Text = (myReader["clscontact"].ToString());
               txtadd.Text = (myReader["clsadd"].ToString());
               txtemail.text = (myReader["clsemail"].ToString());
               txtwebsite.text = (myReader["clswebsite"].ToString());
               txtquotes.Text = (myReader["clsquotes"].ToString());





            }
            if (txtname.text == "")
            {
                btnsave.Visible = true;
            }
            else
            {
                label8.Text = "Class Information available..";
            }
            cn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();                                                                         
                    SqlCommand cmd;
                    string qry = "insert into clssetup(class_name,clscontact,clsadd,clsemail,clswebsite,clsquotes) values('" + txtname.text + "','" + mrktxtcontct.Text + "','"+txtadd.Text+"','"+txtemail.text+"','"+txtwebsite.text+"','"+txtquotes.Text+"')";

                    cmd = new SqlCommand(qry, cn);
                   // cn.Close();
                   
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        //   Form1_Load(sender,e);
                         MessageBox.Show("Setup Succesful");
                         btnsave.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Setup Succesful");
                    }
                    cn.Close();
                

            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from clssetup where class_name='" + txtname.text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);

                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                   // course_Load(sender, e);
                    MessageBox.Show("deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to delete");
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
           label8.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {                                                                                              
                string qry = "update clssetup set class_name='" + txtname.text + "',clscontact='" + mrktxtcontct.Text + "',clsadd= '" + txtadd.Text + "',clsemail= '" + txtemail.text + "',clswebsite='" + txtwebsite.text + "',clsquotes='" + txtquotes.Text + "' where setup_id='" + txtid.text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);
                cn.Close();
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //course_Load(sender, e);
                    MessageBox.Show("update Successfully");
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

        private void frmsetup_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
        }
    }
}
