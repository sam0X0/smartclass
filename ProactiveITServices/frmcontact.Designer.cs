namespace ProactiveITServices
{
    partial class frmcontact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontact));
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtussername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtserver = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtsubject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblhost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcmp = new System.Windows.Forms.Label();
            this.prb = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.lblstaus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnsend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnfetch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblerr = new System.Windows.Forms.Label();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pntop
            // 
            this.pntop.BackColor = System.Drawing.Color.Black;
            this.pntop.Controls.Add(this.label1);
            this.pntop.Controls.Add(this.btnclose);
            this.pntop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntop.Location = new System.Drawing.Point(0, 0);
            this.pntop.Name = "pntop";
            this.pntop.Size = new System.Drawing.Size(750, 53);
            this.pntop.TabIndex = 6;
            this.pntop.Paint += new System.Windows.Forms.PaintEventHandler(this.pntop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sending Emails";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(679, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(71, 53);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(13, 96);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(97, 18);
            this.lbluname.TabIndex = 5;
            this.lbluname.Text = "USER EMAIL";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.Location = new System.Drawing.Point(13, 142);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(96, 18);
            this.lblpwd.TabIndex = 7;
            this.lblpwd.Text = "PASSWORD";
            // 
            // txtussername
            // 
            this.txtussername.BackColor = System.Drawing.Color.White;
            this.txtussername.BorderColorFocused = System.Drawing.Color.Black;
            this.txtussername.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtussername.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtussername.BorderThickness = 2;
            this.txtussername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtussername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtussername.ForeColor = System.Drawing.Color.Black;
            this.txtussername.isPassword = false;
            this.txtussername.Location = new System.Drawing.Point(134, 83);
            this.txtussername.Margin = new System.Windows.Forms.Padding(4);
            this.txtussername.Name = "txtussername";
            this.txtussername.Size = new System.Drawing.Size(251, 34);
            this.txtussername.TabIndex = 0;
            this.txtussername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtussername.OnValueChanged += new System.EventHandler(this.txtussername_OnValueChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderColorFocused = System.Drawing.Color.Black;
            this.txtpassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtpassword.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtpassword.BorderThickness = 2;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.isPassword = true;
            this.txtpassword.Location = new System.Drawing.Point(134, 125);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(251, 35);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtserver
            // 
            this.txtserver.BackColor = System.Drawing.Color.White;
            this.txtserver.BorderColorFocused = System.Drawing.Color.Black;
            this.txtserver.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtserver.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtserver.BorderThickness = 2;
            this.txtserver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtserver.Enabled = false;
            this.txtserver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.ForeColor = System.Drawing.Color.Black;
            this.txtserver.isPassword = false;
            this.txtserver.Location = new System.Drawing.Point(135, 228);
            this.txtserver.Margin = new System.Windows.Forms.Padding(4);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(251, 35);
            this.txtserver.TabIndex = 13;
            this.txtserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsubject
            // 
            this.txtsubject.BackColor = System.Drawing.Color.White;
            this.txtsubject.BorderColorFocused = System.Drawing.Color.Black;
            this.txtsubject.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtsubject.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtsubject.BorderThickness = 2;
            this.txtsubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.ForeColor = System.Drawing.Color.Black;
            this.txtsubject.isPassword = false;
            this.txtsubject.Location = new System.Drawing.Point(135, 185);
            this.txtsubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(251, 35);
            this.txtsubject.TabIndex = 4;
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblhost
            // 
            this.lblhost.AutoSize = true;
            this.lblhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhost.Location = new System.Drawing.Point(13, 238);
            this.lblhost.Name = "lblhost";
            this.lblhost.Size = new System.Drawing.Size(115, 18);
            this.lblhost.TabIndex = 11;
            this.lblhost.Text = "SERVER/HOST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "SUBJECT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblcmp);
            this.panel1.Controls.Add(this.prb);
            this.panel1.Controls.Add(this.pictbox2);
            this.panel1.Controls.Add(this.picbox1);
            this.panel1.Controls.Add(this.lblstaus);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnsend);
            this.panel1.Controls.Add(this.btnfetch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 337);
            this.panel1.TabIndex = 14;
            // 
            // lblcmp
            // 
            this.lblcmp.AutoSize = true;
            this.lblcmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmp.Location = new System.Drawing.Point(116, 309);
            this.lblcmp.Name = "lblcmp";
            this.lblcmp.Size = new System.Drawing.Size(0, 16);
            this.lblcmp.TabIndex = 27;
            // 
            // prb
            // 
            this.prb.animated = false;
            this.prb.animationIterval = 5;
            this.prb.animationSpeed = 300;
            this.prb.BackColor = System.Drawing.Color.Transparent;
            this.prb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prb.BackgroundImage")));
            this.prb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prb.ForeColor = System.Drawing.Color.SeaGreen;
            this.prb.LabelVisible = true;
            this.prb.LineProgressThickness = 8;
            this.prb.LineThickness = 5;
            this.prb.Location = new System.Drawing.Point(114, 215);
            this.prb.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.prb.MaxValue = 100;
            this.prb.Name = "prb";
            this.prb.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prb.ProgressColor = System.Drawing.Color.SeaGreen;
            this.prb.Size = new System.Drawing.Size(92, 92);
            this.prb.TabIndex = 25;
            this.prb.Value = 0;
            this.prb.Visible = false;
            // 
            // pictbox2
            // 
            this.pictbox2.Image = global::ProactiveITServices.Properties.Resources.wifioff1;
            this.pictbox2.Location = new System.Drawing.Point(288, 9);
            this.pictbox2.Name = "pictbox2";
            this.pictbox2.Size = new System.Drawing.Size(41, 36);
            this.pictbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictbox2.TabIndex = 24;
            this.pictbox2.TabStop = false;
            this.pictbox2.Visible = false;
            // 
            // picbox1
            // 
            this.picbox1.Image = global::ProactiveITServices.Properties.Resources.wifion1;
            this.picbox1.Location = new System.Drawing.Point(288, 9);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(41, 36);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 23;
            this.picbox1.TabStop = false;
            this.picbox1.Visible = false;
            // 
            // lblstaus
            // 
            this.lblstaus.AutoSize = true;
            this.lblstaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaus.Location = new System.Drawing.Point(238, 27);
            this.lblstaus.Name = "lblstaus";
            this.lblstaus.Size = new System.Drawing.Size(0, 18);
            this.lblstaus.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 50;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(3, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(334, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnsend
            // 
            this.btnsend.ActiveBorderThickness = 1;
            this.btnsend.ActiveCornerRadius = 20;
            this.btnsend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsend.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnsend.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.ButtonText = "Send";
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.Transparent;
            this.btnsend.IdleBorderThickness = 1;
            this.btnsend.IdleCornerRadius = 20;
            this.btnsend.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnsend.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsend.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsend.Location = new System.Drawing.Point(171, 176);
            this.btnsend.Margin = new System.Windows.Forms.Padding(5);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(134, 41);
            this.btnsend.TabIndex = 2;
            this.btnsend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnfetch
            // 
            this.btnfetch.ActiveBorderThickness = 1;
            this.btnfetch.ActiveCornerRadius = 20;
            this.btnfetch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnfetch.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnfetch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnfetch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnfetch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfetch.BackgroundImage")));
            this.btnfetch.ButtonText = "Fetch";
            this.btnfetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnfetch.IdleBorderThickness = 1;
            this.btnfetch.IdleCornerRadius = 20;
            this.btnfetch.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnfetch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnfetch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnfetch.Location = new System.Drawing.Point(17, 176);
            this.btnfetch.Margin = new System.Windows.Forms.Padding(5);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(134, 41);
            this.btnfetch.TabIndex = 1;
            this.btnfetch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "FETCH EMAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Message";
            // 
            // txtmsg
            // 
            this.txtmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsg.Location = new System.Drawing.Point(140, 287);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(244, 74);
            this.txtmsg.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Remember";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(261, 163);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerr.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerr.Location = new System.Drawing.Point(176, 61);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(0, 18);
            this.lblerr.TabIndex = 18;
            // 
            // frmcontact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 390);
            this.Controls.Add(this.lblerr);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.lblhost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtussername);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmcontact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.frmcontact_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcontact_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpwd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtussername;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtserver;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsubject;
        private System.Windows.Forms.Label lblhost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmsg;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsend;
        private Bunifu.Framework.UI.BunifuThinButton2 btnfetch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Label lblstaus;
        private System.Windows.Forms.PictureBox pictbox2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblcmp;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblerr;
    }
}