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
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void course_Load(object sender, EventArgs e)
        {
            //Guid temp;
            //temp = Guid.NewGuid();
            //txtid.text = temp.ToString().Replace("-","");
            //DataTable dt = new DataTable();
           // cn.Open();
           // SqlDataReader myReader = null;
           // SqlCommand myCommand = new SqlCommand(@"SELECT * FROM crs1", cn);
           // //  @" SELECT * FROM Images where id = @id
           //
           // myReader = myCommand.ExecuteReader();
           //
           // while (myReader.Read())
           // {
           //     txtid.text = (myReader["course_id"].ToString());
           //
           // }
           // cn.Close();

            string qry = "select * from crs1";
   
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
            dataGridView1.Rows.Clear();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["course_id"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["course_name"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["fess"].ToString();
                




            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (txtname.text == "")
                {

                    MessageBox.Show("Insert Course Name");
                }
                else
                {
                    SqlCommand cmd;
                    string qry = "insert into crs1(course_name,fess) values('" + txtname.text + "','" + txtfees.text + "')";

                    cmd = new SqlCommand(qry, cn);
                    cn.Close();
                    cn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        //   Form1_Load(sender,e);
                        course_Load(sender, e);
                        MessageBox.Show("Insert Successfully");
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

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update crs1 set course_name='" + txtname.text + "',fess='" + txtfees.text + "' where course_id='" + txtid.text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);
                cn.Close();
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    course_Load(sender, e);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtid.text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtname.text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtfees.text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong..!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from crs1 where course_id='" + txtid.text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);

                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    course_Load(sender, e);
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

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.text, "^[a-zA-z]"))
            {
              string  qry = "select * from crs1 where course_id like '" +txtsearch.text.Trim() + "%'";
                try
                {

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                    dataGridView1.Rows.Clear();
                    sda.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["course_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["course_name"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["fess"].ToString();
                       

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        //lblreslt.BackColor = Color.Red;
                        //lblreslt.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        //lblid.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        //lblreslt.Visible = true;
                       // lblreslt.BackColor = Color.Red;
                        lblid.Text = "Record Found !";

                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                }

            }
            else
            {
                 string qry = "select  * from crs1 where course_name like '" + txtsearch.text.Trim() + "%'";
                try
                {

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                    dataGridView1.Rows.Clear();
                    sda.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["course_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["course_name"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["fess"].ToString();
                        

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        
                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        
                        lblid.Text = "Record Found !";

                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                }

            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void course_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        }
    }

    

