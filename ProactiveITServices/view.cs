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

namespace ProactiveITServices
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();

        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        string qry = "select * from stdreg where studen_id like '%' order by studen_id asc";
        int count = 0;


        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proactiveDataSet.stdreg' table. You can move, or remove it, as needed.
            // this.stdregTableAdapter.Fill(this.proactiveDataSet.stdreg);


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

                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["studen_id"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["name"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["surname"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["dob"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["gender"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["contact"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["address"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["course"].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i]["duration"].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i]["moth"].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i]["jdate"].ToString();
                    dataGridView1.Rows[i].Cells[12].Value = dt.Rows[i]["email"].ToString();
                    dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i]["image"].ToString();
                    //        StudentReg f2 = new StudentReg();
                    //       StudentReg f2 = new StudentReg();
                    //f2.pictbox.Image = dataGridView1.CurrentRow.Cells[12].Value as Image;


                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

        }

        private void txtname_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            this.Visible = false;
            StudentReg f2 = new StudentReg();
            f2.btnupdate.Visible = true;
            f2.txtv.Visible = false;
            f2.txtid1.Visible = true;
            f2.btnsave.Visible = false;
            f2.txtid1.text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f2.txtname.text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.txtsurname.text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.mrktxtdob.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f2.cmbgender.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f2.mrktxtcontct.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f2.txtadd.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f2.txtourses.text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            f2.cmbduration.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            f2.cmbmoth.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            f2.mrktxtdate.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            f2.txtemail.text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            // f2.pictureBox1.Image = this.dataGridView1.CurrentRow.Cells[12].Value as Image;

            f2.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
        }

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.text, "^[a-zA-z]"))
            {
                qry = "select * from stdreg where studen_id like '" + txtsearch.text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["studen_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["name"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["surname"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["dob"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["gender"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["contact"].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["address"].ToString();
                        dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["course"].ToString();
                        dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i]["duration"].ToString();
                        dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i]["moth"].ToString();
                        dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i]["jdate"].ToString();
                        dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i]["email"].ToString();
                        //f2.pictbox.Image = dataGridView1.CurrentRow.Cells[12].Value as Image;


                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        // lblreslt.BackColor = Color.Red;
                        lblreslt.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        lblreslt.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        lblid.Visible = true;
                        //lblreslt.BackColor = Color.Red;
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
                qry = "select  * from stdreg where name like '" + txtsearch.text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["studen_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["name"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["surname"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["dob"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["gender"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["contact"].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["address"].ToString();
                        dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["course"].ToString();
                        dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i]["duration"].ToString();
                        dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i]["moth"].ToString();
                        dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i]["jdate"].ToString();
                        dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i]["email"].ToString();


                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblid.Text = "OOPS Record Not Found !";
                        // lblreslt.BackColor = Color.Red;
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
                        // lblreslt.BackColor = Color.Red;
                        lblid.Text = "Record Found !";

                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                }

            }




        }

        private void txtdelete_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.text, "^[a-zA-z]"))
            {
                try
                {
                    string qry = "delete from stdreg where studen_id='" + txtsearch.text + "'";

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
            else
            {
                try
                {
                    string qry = "delete from stdreg where name='" + txtsearch.text + "'";

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

    }
}
    

