namespace ProactiveITServices
{
    partial class course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btndelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtid = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtfees = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pntop.Size = new System.Drawing.Size(556, 45);
            this.pntop.TabIndex = 2;
            this.pntop.Paint += new System.Windows.Forms.PaintEventHandler(this.pntop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Course ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(480, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(2, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Course-Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(406, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 278);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Controls";
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btndelete.ActiveForecolor = System.Drawing.Color.White;
            this.btndelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.ButtonText = "Delete";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 20;
            this.btndelete.IdleFillColor = System.Drawing.Color.Transparent;
            this.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Location = new System.Drawing.Point(3, 195);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ActiveBorderThickness = 1;
            this.btnupdate.ActiveCornerRadius = 20;
            this.btnupdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnupdate.Location = new System.Drawing.Point(3, 144);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 41);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnsave.Location = new System.Drawing.Point(2, 93);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(139, 41);
            this.btnsave.TabIndex = 0;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(148, 276);
            this.shapeContainer2.TabIndex = 33;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Red;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 17;
            this.lineShape4.X2 = 140;
            this.lineShape4.Y1 = 32;
            this.lineShape4.Y2 = 32;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Red;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 18;
            this.lineShape2.X2 = 141;
            this.lineShape2.Y1 = 66;
            this.lineShape2.Y2 = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 101);
            this.panel1.TabIndex = 20;
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
            this.course_id,
            this.course_name,
            this.fess});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.dataGridView1.Size = new System.Drawing.Size(405, 101);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // course_id
            // 
            this.course_id.HeaderText = "Course-Id";
            this.course_id.Name = "course_id";
            this.course_id.ReadOnly = true;
            this.course_id.Width = 91;
            // 
            // course_name
            // 
            this.course_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.course_name.HeaderText = "Course";
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            // 
            // fess
            // 
            this.fess.HeaderText = "Fees";
            this.fess.Name = "fess";
            this.fess.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course-Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(5, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearch.BackgroundImage")));
            this.txtsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtsearch.Icon")));
            this.txtsearch.Location = new System.Drawing.Point(109, 165);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(232, 29);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.text = "";
            this.txtsearch.OnTextChange += new System.EventHandler(this.txtsearch_OnTextChange);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtname.BackgroundImage")));
            this.txtname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Icon = ((System.Drawing.Image)(resources.GetObject("txtname.Icon")));
            this.txtname.Location = new System.Drawing.Point(110, 91);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 32);
            this.txtname.TabIndex = 1;
            this.txtname.text = "";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtid.BackgroundImage")));
            this.txtid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtid.Enabled = false;
            this.txtid.ForeColor = System.Drawing.Color.DimGray;
            this.txtid.Icon = ((System.Drawing.Image)(resources.GetObject("txtid.Icon")));
            this.txtid.Location = new System.Drawing.Point(111, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(98, 35);
            this.txtid.TabIndex = 0;
            this.txtid.text = "";
            // 
            // txtfees
            // 
            this.txtfees.BackColor = System.Drawing.Color.White;
            this.txtfees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtfees.BackgroundImage")));
            this.txtfees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtfees.ForeColor = System.Drawing.Color.Black;
            this.txtfees.Icon = ((System.Drawing.Image)(resources.GetObject("txtfees.Icon")));
            this.txtfees.Location = new System.Drawing.Point(109, 128);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(227, 29);
            this.txtfees.TabIndex = 2;
            this.txtfees.text = "";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(56, 200);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 323);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtfees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Load += new System.EventHandler(this.course_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.course_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuTextbox txtname;
        public Bunifu.Framework.UI.BunifuTextbox txtfees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        public Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        public Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public Bunifu.Framework.UI.BunifuTextbox txtsearch;
        public Bunifu.Framework.UI.BunifuThinButton2 btndelete;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuTextbox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fess;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblid;
    }
}