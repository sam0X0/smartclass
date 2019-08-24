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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        string qry = "SELECT stdfees.studen_id, stdfees.course_name, stdfees.pfees, stdfees.pdate, stdfees.rmfees, stdfees.payfees,stdfees.fees_id FROM stdreg INNER JOIN stdfees ON stdreg.studen_id = stdfees.studen_id";
        int count = 0;

        private void fees_Load(object sender, EventArgs e)
        {
            cn.Open();
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

                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["fees_id"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["studen_id"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["course_name"].ToString();

                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["pfees"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["pdate"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["rmfees"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["payfees"].ToString();

                    //        StudentReg f2 = new StudentReg();
                    //       StudentReg f2 = new StudentReg();
                    //f2.pictbox.Image = dataGridView1.CurrentRow.Cells[12].Value as Image;


                }
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            this.Visible = false;
            studentfees f2 = new studentfees();
            // f2.btnupdate.Visible = true;
            //f2.label2.Visible = true;
            f2.txtid.Visible = true;
            f2.btnsave.Visible = false;
            f2.txtfeesid.text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f2.txtid.text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            f2.txtourses.text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.txtfees.text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f2.mrktxtpdat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f2.txtrmfees.text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f2.paidfees.text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f2.btnupdate.Visible = true;
            f2.linkLabel1.Visible = false;
            f2.txtid.Enabled = false;
           
            
                if (f2.txtid.text == "")
                {
                    //f2.lblid.Text = "Student Id Is blank !";
                }
                else
                {

                    StudentReg std = new StudentReg();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT * FROM stdreg where studen_id='" + f2.txtid.text + "' ", cn);
                    //  @" SELECT * FROM Images where id = @id
                    cn.Close();
                    cn.Open();
                    myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        f2.txtname.text = (myReader["name"].ToString());
                        f2.txtsurname.text = (myReader["surname"].ToString());
                        f2.mrktxtcontct.Text = (myReader["contact"].ToString());
                        f2.txtourses.text = (myReader["course"].ToString());
                        f2.cmbduration.Text = (myReader["duration"].ToString());
                        f2.cmbmoth.Text = (myReader["moth"].ToString());
                        f2.mrktxtdate.Text = (myReader["jdate"].ToString());
                        f2.btnupdate.Visible = true;
                        f2.linkLabel1.Visible = false;
                        f2.txtid.Enabled = false;
                        f2.ShowDialog();

                        //f2. button1_Click(sender, e);
                        //          lblid.Text = "Record Found";
                    }
                    else
                    {
                        //            lblid.Text = "Not Found";
                    }

                }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong !");
            }

            
        }

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.text, "^[a-zA-z]"))
            {
                string qry = "select * from stdfees where fees_id like '" + txtsearch.text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["fees_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["studen_id"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["course_name"].ToString();

                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["pfees"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["pdate"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["rmfees"].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["payfees"].ToString();

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        //    lblid.BackColor = Color.Red;
                        lblid.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        lblid.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        lblid.Visible = true;
                        //  lblid.BackColor = Color.Red;
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

                string qry = "select * from stdfees where course_name like '" + txtsearch.text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["fees_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["studen_id"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["course_name"].ToString();

                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["pfees"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["pdate"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["rmfees"].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["payfees"].ToString();

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        //    lblid.BackColor = Color.Red;
                        lblid.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        lblid.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        lblid.Visible = true;
                        //  lblid.BackColor = Color.Red;
                        lblid.Text = "Record Found !";

                    }

                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                } 
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

        private void txtdelete_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.text, "^[a-zA-z]"))
            {
                try
                {
                    string qry = "delete from stdfees where fees_id='" + txtsearch.text + "'";

                    SqlCommand cmd = new SqlCommand(qry, cn);
                    cn.Close();
                    cn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("deleted Successfully");
                        txtsearch.text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete or Select Invalid Id");
                    }
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong !!");
                }

            }
            else
            {
                try
                {
                    string qry = "delete from stdfees where course_name='" + txtsearch.text + "'";

                    SqlCommand cmd = new SqlCommand(qry, cn);
                    cn.Close();
                    cn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("deleted Successfully");
                        txtsearch.text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete");
                    }
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong !!");
                }
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fees_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
