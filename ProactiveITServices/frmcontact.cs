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
using System.Net.Mail;
using System.Threading;
using System.Net.NetworkInformation;


namespace ProactiveITServices
{
    public partial class frmcontact : Form
    {
        int valup = 0;
        public frmcontact()
        {
            InitializeComponent();
            txtserver.Text = "smtp.gmail.com";
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-2FDFRQR\SQLEXPRESS;Initial Catalog=proactive;Integrated Security=True");
       
        private void frmcontact_Load(object sender, EventArgs e)
        {
           
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("SELECT email FROM stdreg WHERE email IS NOT NULL ORDER BY studen_id desc", cn);
            //column1, column2, ... ASC|
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["email"].ToString());
                //listBox1.Items.Add(reader["course"].ToString());
            }
            int i = 0;
            while (listBox1.Items.Count - 1 >= i)
            {
                

                if (Convert.ToString(listBox1.Items[i]).Trim() == string.Empty)
                {
                    //if the line became blank after Trim() apply so the line is empty and condition is true
                    listBox1.Items.RemoveAt(i);
                    //decrement i because we remove line and the following line will take his place and his index number
                    i -= 1;
                }
                i += 1;
            }
            cn.Close();
        }

        private void txtussername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (txtsubject.Text == "")
                {
                    lblerr.Text = "Enter Subject..";
;
                }
               else if (txtmsg.Text == "")
                {
                    lblerr.Text = "Enter Message..";
                }
                else if (listBox1.Text == "")
                {
                    lblerr.Text = "Fetch Email Address..";
                }

                SmtpClient client = new SmtpClient(txtserver.Text, 587);
                // System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                MailMessage msg = new MailMessage();
                client.Credentials = new System.Net.NetworkCredential(txtussername.Text, txtpassword.Text);
                client.Timeout = 30000;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                msg.Subject = txtsubject.Text;
                msg.Body = txtmsg.Text;
                msg.IsBodyHtml = true;

             
                foreach (string email in listBox1.Items)
                {
                    msg.From = (new MailAddress(txtussername.Text));
                    msg.To.Add(new MailAddress(email));
                    //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                    //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.Delay;
                    //msg.DeliveryNotificationOptions = DeliveryNotificationOptions.Never;

                    client.Send(msg);
                    Thread.Sleep(2000);
                    timer1.Start();

                }
               
                prb.Visible = true;

            
            }
            catch
            {
                lblerr.Text = "Check Username & Password..";
            }
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                Properties.Settings.Default.user = txtussername.Text;
                Properties.Settings.Default.pass = txtpassword.Text;
                checkBox1.Checked = true;
                Properties.Settings.Default.Save();
               
            }
            if(checkBox1.Checked==false)
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                checkBox1.Checked = false;
                Properties.Settings.Default.Save();
              
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtpassword.isPassword = false;
            }
           else if (checkBox2.Checked == false)
            {
                txtpassword.isPassword = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            valup += 1;
            
            prb.Value = valup;
            if (prb.Value == 100) 
            {
                prb.Value = 0;
                timer1.Stop();
               
                lblcmp.ForeColor = Color.Green;
                lblcmp.Text = "Successful Sent.";
                
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pntop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bool check = NetworkInterface.GetIsNetworkAvailable();
            if (check == true)
            {
                picbox1.Visible = true;
                lblstaus.ForeColor = Color.Green;
                lblstaus.Text = "Online";
            }
            else
            {
                picbox1.Visible = true;
                lblstaus.ForeColor = Color.Red;
                lblstaus.Text = "Offline";
            }

            if (Properties.Settings.Default.user != string.Empty)
            {
                txtussername.Text = Properties.Settings.Default.user;
                txtpassword.Text = Properties.Settings.Default.pass;

            }
        }

        private void frmcontact_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
   }
}
