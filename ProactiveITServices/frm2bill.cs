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
    public partial class frm2bill : Form
    {
        public frm2bill()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");

        string qry = "select * from stdfees where fees_id like '%' order by fees_id asc";
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frm2bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billing.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.billing.DataTable1);
           
            this.reportViewer1.RefreshReport();

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
                cn.Close();
            }
            catch
            {

            }
        }

   

      

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch1_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch1.Text == "")
                {
                    frm2bill_Load(sender, e);

                }
                else
                {

                    this.DataTable1TableAdapter.FillBy1(this.billing.DataTable1, ((int)(System.Convert.ChangeType(txtsearch1.Text, typeof(int)))));

                    this.reportViewer1.RefreshReport();


                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

      
           
        private void label3_Click(object sender, EventArgs e)
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

        private void txtsearch_OnValueChanged(object sender, EventArgs e)
        {
            cn.Open();
            string qry = "select * from stdfees where studen_id like '" + txtsearch.Text.Trim() + "%'";
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
                else if (txtsearch.Text == string.Empty)
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
                cn.Close();

            }

            catch
            {
                MessageBox.Show("Something Went Wrong !");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // this.Visible = false;
                // studentfees f2 = new studentfees();
                // f2.btnupdate.Visible = true;
                //f2.label2.Visible = true;
                // f2.txtid.Visible = true;
                // f2.btnsave.Visible = false;
                txtsearch1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
        Bitmap bmp;

        private void frm2bill_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
   
        }
    }

