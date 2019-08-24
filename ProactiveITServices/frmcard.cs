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
    public partial class frmcard : Form
    {
       
        public frmcard()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        private void frmcard_Load(object sender, EventArgs e)
        {
            //txtsearch.CharacterCasing = CharacterCasing.Upper;

            this.KeyPreview = true;
            string qry = "select * from stdreg where studen_id like '%' order by studen_id asc";
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

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }



        private void txtsearch_OnTextChange_1(object sender, EventArgs e)
        {
            try{

            // cn.Close();
                if (txtsearch.text == "")
                {
                    stdid1.Text = string.Empty;
                    stdid.Text = string.Empty;
                    lblclass.Text = string.Empty;
                    lblclass.Text = string.Empty;
                    clsmob.Text = string.Empty;
                    clsmail.Text = string.Empty;
                    sname.Text = string.Empty;
                    surname.Text = string.Empty;
                    sdob.Text = string.Empty;
                    scnt.Text = string.Empty;
                    scrs.Text = string.Empty;
                    semail.Text = string.Empty;
                    clsmail.Text = string.Empty;
                    clsadd.Text = string.Empty;
                    clssite.Text = string.Empty;
                }
                else
                {
                    try
                    {
                        cn.Open();
                    }
                    catch
                    {
                        cn.Close();

                    }
                   

                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(@"SELECT stdreg.studen_id, stdreg.name, stdreg.surname, stdreg.dob, stdreg.contact, stdreg.course, stdreg.email, clssetup.Class_name, clssetup.clscontact, clssetup.clsadd, clssetup.clsemail, clssetup.clswebsite
FROM  stdreg CROSS JOIN clssetup  where studen_id='" + txtsearch.text + "'", cn);
                    //  @" SELECT * FROM Images where id = @id
                    

                   
                    myReader = myCommand.ExecuteReader();
                   
                        while (myReader.Read())
                        {
                            stdid.Text = (myReader["studen_id"].ToString());
                            lblclass.Text = (myReader["class_name"].ToString());
                            clsmob.Text = (myReader["clscontact"].ToString());
                            clsmail.Text = (myReader["clsemail"].ToString());
                            sname.Text = (myReader["name"].ToString());
                            surname.Text = (myReader["surname"].ToString());
                            sdob.Text = (myReader["dob"].ToString());
                            scnt.Text = (myReader["contact"].ToString());
                            scrs.Text = (myReader["course"].ToString());
                            semail.Text = (myReader["email"].ToString());
                            clsmail.Text = (myReader["clsemail"].ToString());
                            clsadd.Text = (myReader["clsadd"].ToString());     

                        }
                    
                    
                    cn.Close();
                }
                 
            }
            catch
            {
                MessageBox.Show("Opps Some ERROR!");
                cn.Close();
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void topColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bottomColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnlbtm.BackColor = colorDialog1.Color;
            }
        }

        private void allCardTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void topTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bottomTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cardTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void topTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttomTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void backgoundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void topImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttomImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void strechImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void zoomImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stretchImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblclass_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clsmob_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addIngImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cardTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fontd.ShowDialog() != DialogResult.Cancel)
            {

                 sname.Font= fontd.Font;
                 surname.Font= fontd.Font;
                 sdob.Font= fontd.Font;
                 scnt.Font=fontd.Font;
                scrs.Font=fontd.Font;
                semail.Font=fontd.Font;
        } 
    }
        private void topTextToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (fontd.ShowDialog() != DialogResult.Cancel)
            {

              lblclass.Font= fontd.Font;
              clsmob.  Font  = fontd.Font;
              clsmail.Font = fontd.Font;
               }
        }

        private void buttomTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fontd.ShowDialog() != DialogResult.Cancel)
            {

                clsadd.Font = fontd.Font;
                clssite.Font = fontd.Font;
            }  
        }

        private void allCardTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnlcard.ForeColor = colorDialog1.Color;
                clsmail.ForeColor = colorDialog1.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnlcard.BackColor = colorDialog1.Color;
            }
        }

        private void topColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnltop.BackColor = colorDialog1.Color;
            }
        }

        private void bottomColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnlbtm.BackColor = colorDialog1.Color;
            }
        }

        private void backgoundImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pnlcard.BackgroundImage = new Bitmap(open.FileName);

                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        private void topImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pnltop.BackgroundImage = new Bitmap(open.FileName);

                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        private void buttomImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pnlbtm.BackgroundImage = new Bitmap(open.FileName);

                // image file path  
                //textBox1.Text = open.FileName;
            }
        }

        private void bottomTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnlbtm.ForeColor = colorDialog1.Color;
            }
        }

        private void topTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pnltop.ForeColor = colorDialog1.Color;
                clsmail.ForeColor = colorDialog1.Color;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.pnlcard.Width, this.pnlcard.Height);
            pnlcard.DrawToBitmap(bm, new Rectangle(0, 0, this.pnlcard.Width, this.pnlcard.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void frmcard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                printDocument1.Print();
            
            }
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                view view = new view();
                view.ShowDialog();

            }

        }

        private void txtsearch_KeyPress(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_KeyDown(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sname_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                stdimage.Image = new Bitmap(open.FileName);
                // image file path  

            }   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          txtsearch.text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtstdsearch_OnTextChange(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtstdsearch.text, "^[a-zA-z]"))
            {
                string qry = "select * from stdreg where studen_id like '" + txtstdsearch.text.Trim() + "%'";
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
                      //  lblreslt.Visible = true;

                    }
                    else if (txtsearch.text == string.Empty)
                    {
                       // lblreslt.Visible = true;
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
                string qry = "select  * from stdreg where name like '" + txtstdsearch.text.Trim() + "%'";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblid.ForeColor = Color.FromArgb(one, two, three, four);
        }
    }
}
