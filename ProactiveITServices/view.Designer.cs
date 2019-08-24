namespace ProactiveITServices
{
    partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnsearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblreslt = new System.Windows.Forms.LinkLabel();
            this.txtdelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblid = new System.Windows.Forms.Label();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pntop.Size = new System.Drawing.Size(404, 53);
            this.pntop.TabIndex = 2;
            this.pntop.Paint += new System.Windows.Forms.PaintEventHandler(this.pntop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Search";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(333, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(71, 42);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnclose_PreviewKeyDown);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearch.BackgroundImage")));
            this.txtsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtsearch.Icon")));
            this.txtsearch.Location = new System.Drawing.Point(66, 68);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(252, 42);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.text = "";
            this.txtsearch.OnTextChange += new System.EventHandler(this.txtsearch_OnTextChange);
            // 
            // btnsearch
            // 
            this.btnsearch.ActiveBorderThickness = 1;
            this.btnsearch.ActiveCornerRadius = 20;
            this.btnsearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnsearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.ButtonText = "Search";
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.IdleBorderThickness = 1;
            this.btnsearch.IdleCornerRadius = 20;
            this.btnsearch.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnsearch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsearch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.Location = new System.Drawing.Point(19, 115);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(134, 41);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 151);
            this.panel1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studen_id,
            this.name,
            this.surname,
            this.dob,
            this.gender,
            this.contact,
            this.address,
            this.course,
            this.duration,
            this.moth,
            this.jdate,
            this.image,
            this.email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(403, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // studen_id
            // 
            this.studen_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.studen_id.HeaderText = "Student-ID";
            this.studen_id.Name = "studen_id";
            this.studen_id.ReadOnly = true;
            this.studen_id.Width = 95;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Visible = false;
            // 
            // dob
            // 
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Visible = false;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Visible = false;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Visible = false;
            // 
            // moth
            // 
            this.moth.HeaderText = "Month";
            this.moth.Name = "moth";
            this.moth.ReadOnly = true;
            this.moth.Visible = false;
            // 
            // jdate
            // 
            this.jdate.HeaderText = "joining";
            this.jdate.Name = "jdate";
            this.jdate.ReadOnly = true;
            this.jdate.Visible = false;
            // 
            // image
            // 
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email-ID";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // lblreslt
            // 
            this.lblreslt.AutoSize = true;
            this.lblreslt.LinkColor = System.Drawing.Color.Black;
            this.lblreslt.Location = new System.Drawing.Point(154, 167);
            this.lblreslt.Name = "lblreslt";
            this.lblreslt.Size = new System.Drawing.Size(0, 13);
            this.lblreslt.TabIndex = 42;
            this.lblreslt.Visible = false;
            // 
            // txtdelete
            // 
            this.txtdelete.ActiveBorderThickness = 1;
            this.txtdelete.ActiveCornerRadius = 20;
            this.txtdelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.txtdelete.ActiveForecolor = System.Drawing.Color.White;
            this.txtdelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.txtdelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtdelete.BackgroundImage")));
            this.txtdelete.ButtonText = "Delete";
            this.txtdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtdelete.IdleBorderThickness = 1;
            this.txtdelete.IdleCornerRadius = 20;
            this.txtdelete.IdleFillColor = System.Drawing.Color.Transparent;
            this.txtdelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.txtdelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.txtdelete.Location = new System.Drawing.Point(221, 118);
            this.txtdelete.Margin = new System.Windows.Forms.Padding(5);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(134, 41);
            this.txtdelete.TabIndex = 2;
            this.txtdelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(126, 161);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 49;
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(404, 335);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.lblreslt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.Course_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.view_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lblreslt;
        private Bunifu.Framework.UI.BunifuThinButton2 txtdelete;
        public Bunifu.Framework.UI.BunifuTextbox txtsearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridViewTextBoxColumn studen_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn moth;
        private System.Windows.Forms.DataGridViewTextBoxColumn jdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        public System.Windows.Forms.Panel panel1;
    }
}