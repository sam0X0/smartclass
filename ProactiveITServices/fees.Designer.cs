namespace ProactiveITServices
{
    partial class fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fees_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmfees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payfees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtdelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtsearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.pntop.Size = new System.Drawing.Size(304, 45);
            this.pntop.TabIndex = 3;
            this.pntop.Paint += new System.Windows.Forms.PaintEventHandler(this.pntop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fees Detail";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(227, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.fees_id,
            this.Studen_id,
            this.course,
            this.pfees,
            this.pdate,
            this.rmfees,
            this.payfees});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
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
            this.dataGridView1.Size = new System.Drawing.Size(304, 76);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fees_id
            // 
            this.fees_id.HeaderText = "ID";
            this.fees_id.Name = "fees_id";
            this.fees_id.ReadOnly = true;
            // 
            // Studen_id
            // 
            this.Studen_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Studen_id.HeaderText = "Student-ID";
            this.Studen_id.Name = "Studen_id";
            this.Studen_id.ReadOnly = true;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            // 
            // pfees
            // 
            this.pfees.HeaderText = "Fees";
            this.pfees.Name = "pfees";
            this.pfees.ReadOnly = true;
            this.pfees.Visible = false;
            // 
            // pdate
            // 
            this.pdate.HeaderText = "Pay Date";
            this.pdate.Name = "pdate";
            this.pdate.ReadOnly = true;
            this.pdate.Visible = false;
            // 
            // rmfees
            // 
            this.rmfees.HeaderText = "Remaing";
            this.rmfees.Name = "rmfees";
            this.rmfees.ReadOnly = true;
            this.rmfees.Visible = false;
            // 
            // payfees
            // 
            this.payfees.HeaderText = "Paied";
            this.payfees.Name = "payfees";
            this.payfees.ReadOnly = true;
            this.payfees.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(92, 147);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 48;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.txtdelete.Location = new System.Drawing.Point(85, 104);
            this.txtdelete.Margin = new System.Windows.Forms.Padding(5);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(113, 41);
            this.txtdelete.TabIndex = 1;
            this.txtdelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearch.BackgroundImage")));
            this.txtsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtsearch.Icon")));
            this.txtsearch.Location = new System.Drawing.Point(15, 61);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(258, 42);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.text = "";
            this.txtsearch.OnTextChange += new System.EventHandler(this.txtsearch_OnTextChange);
            // 
            // fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(304, 247);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.fees_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fees_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 txtdelete;
        public Bunifu.Framework.UI.BunifuTextbox txtsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fees_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studen_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfees;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmfees;
        private System.Windows.Forms.DataGridViewTextBoxColumn payfees;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Timer timer1;
    }
}