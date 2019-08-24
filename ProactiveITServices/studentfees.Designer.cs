namespace ProactiveITServices
{
    partial class studentfees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentfees));
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.mrktxtdate = new System.Windows.Forms.MaskedTextBox();
            this.cmbmoth = new System.Windows.Forms.ComboBox();
            this.cmbduration = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mrktxtcontct = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlbldate = new System.Windows.Forms.LinkLabel();
            this.txtfeesid = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtrmfees = new Bunifu.Framework.UI.BunifuTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsurname = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtourses = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtfees = new Bunifu.Framework.UI.BunifuTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.paidfees = new Bunifu.Framework.UI.BunifuTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.mrktxtpdat = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btview = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnstddata = new Bunifu.Framework.UI.BunifuThinButton2();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pntop
            // 
            this.pntop.BackColor = System.Drawing.Color.Black;
            this.pntop.Controls.Add(this.label1);
            this.pntop.Controls.Add(this.bunifuImageButton1);
            this.pntop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntop.Location = new System.Drawing.Point(0, 0);
            this.pntop.Name = "pntop";
            this.pntop.Size = new System.Drawing.Size(568, 39);
            this.pntop.TabIndex = 2;
            this.pntop.Paint += new System.Windows.Forms.PaintEventHandler(this.pntop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Fees";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(495, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // mrktxtdate
            // 
            this.mrktxtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mrktxtdate.Enabled = false;
            this.mrktxtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrktxtdate.Location = new System.Drawing.Point(119, 256);
            this.mrktxtdate.Mask = "00/00/0000";
            this.mrktxtdate.Name = "mrktxtdate";
            this.mrktxtdate.Size = new System.Drawing.Size(208, 29);
            this.mrktxtdate.TabIndex = 7;
            this.mrktxtdate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbmoth
            // 
            this.cmbmoth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbmoth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoth.Enabled = false;
            this.cmbmoth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbmoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmoth.FormattingEnabled = true;
            this.cmbmoth.Items.AddRange(new object[] {
            "Duration Type",
            "Month",
            "Year",
            "Week"});
            this.cmbmoth.Location = new System.Drawing.Point(118, 222);
            this.cmbmoth.Name = "cmbmoth";
            this.cmbmoth.Size = new System.Drawing.Size(125, 28);
            this.cmbmoth.TabIndex = 5;
            // 
            // cmbduration
            // 
            this.cmbduration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbduration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbduration.Enabled = false;
            this.cmbduration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbduration.FormattingEnabled = true;
            this.cmbduration.Items.AddRange(new object[] {
            "Duration",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbduration.Location = new System.Drawing.Point(250, 222);
            this.cmbduration.Name = "cmbduration";
            this.cmbduration.Size = new System.Drawing.Size(77, 28);
            this.cmbduration.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(12, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Duration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(12, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Course";
            // 
            // mrktxtcontct
            // 
            this.mrktxtcontct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mrktxtcontct.Enabled = false;
            this.mrktxtcontct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrktxtcontct.Location = new System.Drawing.Point(119, 142);
            this.mrktxtcontct.Mask = "(999) 000-0000";
            this.mrktxtcontct.Name = "mrktxtcontct";
            this.mrktxtcontct.Size = new System.Drawing.Size(200, 29);
            this.mrktxtcontct.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Surnmae";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Joining Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lnlbldate);
            this.panel1.Controls.Add(this.txtfeesid);
            this.panel1.Controls.Add(this.txtrmfees);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbduration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbmoth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtsurname);
            this.panel1.Controls.Add(this.txtourses);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mrktxtcontct);
            this.panel1.Controls.Add(this.txtfees);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.paidfees);
            this.panel1.Controls.Add(this.mrktxtdate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mrktxtpdat);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 484);
            this.panel1.TabIndex = 48;
            // 
            // lnlbldate
            // 
            this.lnlbldate.AutoSize = true;
            this.lnlbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlbldate.Location = new System.Drawing.Point(249, 432);
            this.lnlbldate.Name = "lnlbldate";
            this.lnlbldate.Size = new System.Drawing.Size(67, 16);
            this.lnlbldate.TabIndex = 12;
            this.lnlbldate.TabStop = true;
            this.lnlbldate.Text = "Get date";
            this.lnlbldate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlbldate_LinkClicked_1);
            // 
            // txtfeesid
            // 
            this.txtfeesid.BackColor = System.Drawing.Color.White;
            this.txtfeesid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtfeesid.BackgroundImage")));
            this.txtfeesid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtfeesid.ForeColor = System.Drawing.Color.DimGray;
            this.txtfeesid.Icon = ((System.Drawing.Image)(resources.GetObject("txtfeesid.Icon")));
            this.txtfeesid.Location = new System.Drawing.Point(119, 25);
            this.txtfeesid.Name = "txtfeesid";
            this.txtfeesid.Size = new System.Drawing.Size(103, 33);
            this.txtfeesid.TabIndex = 0;
            this.txtfeesid.text = "";
            this.txtfeesid.Visible = false;
            // 
            // txtrmfees
            // 
            this.txtrmfees.BackColor = System.Drawing.Color.White;
            this.txtrmfees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtrmfees.BackgroundImage")));
            this.txtrmfees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtrmfees.ForeColor = System.Drawing.Color.Black;
            this.txtrmfees.Icon = ((System.Drawing.Image)(resources.GetObject("txtrmfees.Icon")));
            this.txtrmfees.Location = new System.Drawing.Point(120, 377);
            this.txtrmfees.Name = "txtrmfees";
            this.txtrmfees.Size = new System.Drawing.Size(208, 34);
            this.txtrmfees.TabIndex = 10;
            this.txtrmfees.text = "";
            this.txtrmfees.OnTextChange += new System.EventHandler(this.txtrmfees_OnTextChange_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(13, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Remaining";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(227, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 16);
            this.linkLabel1.TabIndex = 53;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Fetch Record";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(230, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Student -ID";
            // 
            // txtsurname
            // 
            this.txtsurname.BackColor = System.Drawing.Color.White;
            this.txtsurname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsurname.BackgroundImage")));
            this.txtsurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsurname.Enabled = false;
            this.txtsurname.ForeColor = System.Drawing.Color.Black;
            this.txtsurname.Icon = ((System.Drawing.Image)(resources.GetObject("txtsurname.Icon")));
            this.txtsurname.Location = new System.Drawing.Point(119, 103);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(200, 33);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.text = "";
            // 
            // txtourses
            // 
            this.txtourses.BackColor = System.Drawing.Color.White;
            this.txtourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtourses.BackgroundImage")));
            this.txtourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtourses.Enabled = false;
            this.txtourses.ForeColor = System.Drawing.Color.Black;
            this.txtourses.Icon = ((System.Drawing.Image)(resources.GetObject("txtourses.Icon")));
            this.txtourses.Location = new System.Drawing.Point(119, 177);
            this.txtourses.Name = "txtourses";
            this.txtourses.Size = new System.Drawing.Size(203, 34);
            this.txtourses.TabIndex = 4;
            this.txtourses.text = "";
            this.txtourses.OnTextChange += new System.EventHandler(this.txtourses_OnTextChange);
            this.txtourses.KeyDown += new System.EventHandler(this.txtourses_KeyDown);
            this.txtourses.KeyPress += new System.EventHandler(this.txtourses_KeyPress);
            this.txtourses.Enter += new System.EventHandler(this.txtourses_Enter);
            this.txtourses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtourses_MouseClick);
            // 
            // txtfees
            // 
            this.txtfees.BackColor = System.Drawing.Color.White;
            this.txtfees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtfees.BackgroundImage")));
            this.txtfees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtfees.Enabled = false;
            this.txtfees.ForeColor = System.Drawing.Color.Black;
            this.txtfees.Icon = ((System.Drawing.Image)(resources.GetObject("txtfees.Icon")));
            this.txtfees.Location = new System.Drawing.Point(119, 292);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(208, 34);
            this.txtfees.TabIndex = 8;
            this.txtfees.text = "";
            this.txtfees.OnTextChange += new System.EventHandler(this.txtfees_OnTextChange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Pay Date";
            // 
            // paidfees
            // 
            this.paidfees.BackColor = System.Drawing.Color.White;
            this.paidfees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paidfees.BackgroundImage")));
            this.paidfees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paidfees.ForeColor = System.Drawing.Color.Black;
            this.paidfees.Icon = ((System.Drawing.Image)(resources.GetObject("paidfees.Icon")));
            this.paidfees.Location = new System.Drawing.Point(119, 332);
            this.paidfees.Name = "paidfees";
            this.paidfees.Size = new System.Drawing.Size(208, 34);
            this.paidfees.TabIndex = 9;
            this.paidfees.text = "";
            this.paidfees.OnTextChange += new System.EventHandler(this.txtpfees_OnTextChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Paid Fees";
            // 
            // mrktxtpdat
            // 
            this.mrktxtpdat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mrktxtpdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrktxtpdat.Location = new System.Drawing.Point(119, 424);
            this.mrktxtpdat.Mask = "00/00/0000";
            this.mrktxtpdat.Name = "mrktxtpdat";
            this.mrktxtpdat.Size = new System.Drawing.Size(125, 29);
            this.mrktxtpdat.TabIndex = 11;
            this.mrktxtpdat.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtid.BackgroundImage")));
            this.txtid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtid.ForeColor = System.Drawing.Color.DimGray;
            this.txtid.Icon = ((System.Drawing.Image)(resources.GetObject("txtid.Icon")));
            this.txtid.Location = new System.Drawing.Point(119, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(103, 33);
            this.txtid.TabIndex = 31;
            this.txtid.text = "";
            this.txtid.OnTextChange += new System.EventHandler(this.txtid_OnTextChange);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtname.BackgroundImage")));
            this.txtname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtname.Enabled = false;
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Icon = ((System.Drawing.Image)(resources.GetObject("txtname.Icon")));
            this.txtname.Location = new System.Drawing.Point(119, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(198, 33);
            this.txtname.TabIndex = 1;
            this.txtname.text = "";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(69, 5);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 54;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btview);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnstddata);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(391, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 484);
            this.panel2.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Controls";
            // 
            // btview
            // 
            this.btview.ActiveBorderThickness = 1;
            this.btview.ActiveCornerRadius = 20;
            this.btview.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btview.ActiveForecolor = System.Drawing.Color.White;
            this.btview.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btview.BackColor = System.Drawing.Color.Transparent;
            this.btview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btview.BackgroundImage")));
            this.btview.ButtonText = "View";
            this.btview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btview.ForeColor = System.Drawing.Color.SeaGreen;
            this.btview.IdleBorderThickness = 1;
            this.btview.IdleCornerRadius = 20;
            this.btview.IdleFillColor = System.Drawing.Color.Transparent;
            this.btview.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btview.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btview.Location = new System.Drawing.Point(22, 176);
            this.btview.Margin = new System.Windows.Forms.Padding(5);
            this.btview.Name = "btview";
            this.btview.Size = new System.Drawing.Size(139, 41);
            this.btview.TabIndex = 1;
            this.btview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btview.Click += new System.EventHandler(this.btview_Click);
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "Save";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 20;
            this.btnsave.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnsave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.Location = new System.Drawing.Point(20, 132);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(139, 41);
            this.btnsave.TabIndex = 0;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ActiveBorderThickness = 1;
            this.btnupdate.ActiveCornerRadius = 20;
            this.btnupdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.IdleBorderThickness = 1;
            this.btnupdate.IdleCornerRadius = 20;
            this.btnupdate.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnupdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnupdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.Location = new System.Drawing.Point(23, 221);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 41);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnstddata
            // 
            this.btnstddata.ActiveBorderThickness = 1;
            this.btnstddata.ActiveCornerRadius = 20;
            this.btnstddata.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnstddata.ActiveForecolor = System.Drawing.Color.White;
            this.btnstddata.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnstddata.BackColor = System.Drawing.Color.Transparent;
            this.btnstddata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstddata.BackgroundImage")));
            this.btnstddata.ButtonText = "Student List";
            this.btnstddata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstddata.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnstddata.IdleBorderThickness = 1;
            this.btnstddata.IdleCornerRadius = 20;
            this.btnstddata.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnstddata.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnstddata.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnstddata.Location = new System.Drawing.Point(20, 272);
            this.btnstddata.Margin = new System.Windows.Forms.Padding(5);
            this.btnstddata.Name = "btnstddata";
            this.btnstddata.Size = new System.Drawing.Size(139, 41);
            this.btnstddata.TabIndex = 34;
            this.btnstddata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnstddata.Click += new System.EventHandler(this.btnstddata_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(175, 482);
            this.shapeContainer2.TabIndex = 33;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Red;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 24;
            this.lineShape4.X2 = 147;
            this.lineShape4.Y1 = 65;
            this.lineShape4.Y2 = 65;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Red;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 26;
            this.lineShape2.X2 = 149;
            this.lineShape2.Y1 = 99;
            this.lineShape2.Y2 = 99;
            // 
            // studentfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "studentfees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Fees";
            this.Load += new System.EventHandler(this.studentfees_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.studentfees_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.MaskedTextBox mrktxtdate;
        public System.Windows.Forms.ComboBox cmbmoth;
        public System.Windows.Forms.ComboBox cmbduration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox mrktxtcontct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuTextbox txtname;
        public Bunifu.Framework.UI.BunifuTextbox txtourses;
        public Bunifu.Framework.UI.BunifuTextbox txtid;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuTextbox txtsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuTextbox txtfees;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuTextbox paidfees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox mrktxtpdat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        public Bunifu.Framework.UI.BunifuThinButton2 btview;
        public Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        public Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public Bunifu.Framework.UI.BunifuTextbox txtrmfees;
        private System.Windows.Forms.Label label13;
        public Bunifu.Framework.UI.BunifuTextbox txtfeesid;
        public System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnlbldate;
        public Bunifu.Framework.UI.BunifuThinButton2 btnstddata;

    }
}