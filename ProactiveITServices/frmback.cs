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
    public partial class frmback : Form
    {
        int valup = 0;
        
        public frmback()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                BackupTextBox.Text = fbd.SelectedPath;
                //BrowseBackupBtn.Enabled = true;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            cn.Close();
            cn.Open();
            String database = cn.Database.ToString();
            try
            {
                if (BackupTextBox.Text == string.Empty)
                {
                  //  s.Speak("please enter the valid backup file location");
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + BackupTextBox.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, cn);
                    scmd.ExecuteNonQuery();
                   // s.Speak("Backup taken successfully");
                    prb.Visible = true;
                    timer1.Start();
                    BackupTextBox.Text = string.Empty;
                    txtrestore.Text = string.Empty;
                    

                   
                  

                }
        }
            catch
            {
                lblcmp.ForeColor = Color.Red;
                lblcmp.Text = "Connection or Access denied..";
            }
    

    }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cn.Close();
            cn.Open();
            String database = cn.Database.ToString();
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, cn);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtrestore.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, cn);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.ExecuteNonQuery();
                prb.Visible = true;
                timer2.Start();
                BackupTextBox.Text = string.Empty;
                txtrestore.Text = string.Empty;
               



            }
            catch (Exception ex)
            {
                lblcmp.ForeColor = Color.Red;
                lblcmp.Text = "Connection or Access denied..";
            }
            finally { cn.Close(); }
        }

        private void btnbrowe1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtrestore.Text = ofd.FileName;
                // RestoreBtn.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                valup += 1;

                prb.Value = valup;
                if (prb.Value == 100)
                {
                    prb.Value = 0;
                    timer1.Stop();

                    lblcmp.ForeColor = Color.Green;
                    lblcmp.Text = "Backup Taken Successfully.";

                }
            }
            catch { timer1.Start(); }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtrestore.Text = ofd.FileName;
               // RestoreBtn.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                valup += 1;

                prb.Value = valup;
                if (prb.Value == 100)
                {
                    prb.Value = 0;
                    timer2.Stop();

                    lblcmp.ForeColor = Color.Green;
                    lblcmp.Text = "Restore  Successfully.";

                }
            }
            catch {
                timer2.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.loc = BackupTextBox.Text;

                checkBox1.Checked = true;
                Properties.Settings.Default.Save();

            }
            if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.loc = "";
               
                checkBox1.Checked = false;
                Properties.Settings.Default.Save();

            }
        }

        private void frmback_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.user != string.Empty)
            {
              BackupTextBox.Text = Properties.Settings.Default.loc;
               

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          

        }

        private void frmback_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
}
}
