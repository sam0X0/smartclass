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
    public partial class frmstdview : Form
    {
        public frmstdview()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        string qry = "select * from stdreg where studen_id like '%' order by studen_id asc";
        private void frmstdview_Load(object sender, EventArgs e)
        {
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
                        //lblreslt.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                        //lblreslt.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                        //lblid.Visible = true;
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
                        //lblid.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                       // lblid.Visible = true;
                        lblid.Text = "Text box is Empty !";

                    }
                    else
                    {
                       // lblid.Visible = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmstdview_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            studentfees stdfees = new studentfees();
            stdfees.txtid.text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Visible = false;

            
            stdfees.ShowDialog();

        }
    }
}
