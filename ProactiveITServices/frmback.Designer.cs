namespace ProactiveITServices
{
    partial class frmback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmback));
            this.BackupTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtrestore = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnbrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnbackup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnbrowe1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.prb = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pntop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblcmp = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pntop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // BackupTextBox
            // 
            this.BackupTextBox.BackColor = System.Drawing.Color.White;
            this.BackupTextBox.BorderColorFocused = System.Drawing.Color.Black;
            this.BackupTextBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.BackupTextBox.BorderColorMouseHover = System.Drawing.Color.Black;
            this.BackupTextBox.BorderThickness = 2;
            this.BackupTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackupTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupTextBox.ForeColor = System.Drawing.Color.Black;
            this.BackupTextBox.isPassword = false;
            this.BackupTextBox.Location = new System.Drawing.Point(16, 56);
            this.BackupTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BackupTextBox.Name = "BackupTextBox";
            this.BackupTextBox.Size = new System.Drawing.Size(236, 34);
            this.BackupTextBox.TabIndex = 1;
            this.BackupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtrestore
            // 
            this.txtrestore.BackColor = System.Drawing.Color.White;
            this.txtrestore.BorderColorFocused = System.Drawing.Color.Black;
            this.txtrestore.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtrestore.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtrestore.BorderThickness = 2;
            this.txtrestore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrestore.ForeColor = System.Drawing.Color.Black;
            this.txtrestore.isPassword = false;
            this.txtrestore.Location = new System.Drawing.Point(17, 113);
            this.txtrestore.Margin = new System.Windows.Forms.Padding(4);
            this.txtrestore.Name = "txtrestore";
            this.txtrestore.Size = new System.Drawing.Size(236, 34);
            this.txtrestore.TabIndex = 2;
            this.txtrestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.ActiveBorderThickness = 1;
            this.btnbrowse.ActiveCornerRadius = 20;
            this.btnbrowse.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnbrowse.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowse.BackgroundImage")));
            this.btnbrowse.ButtonText = "Backup  Location";
            this.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.IdleBorderThickness = 1;
            this.btnbrowse.IdleCornerRadius = 20;
            this.btnbrowse.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbrowse.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.Location = new System.Drawing.Point(261, 52);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(133, 41);
            this.btnbrowse.TabIndex = 5;
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnbackup
            // 
            this.btnbackup.ActiveBorderThickness = 1;
            this.btnbackup.ActiveCornerRadius = 20;
            this.btnbackup.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.ActiveForecolor = System.Drawing.Color.White;
            this.btnbackup.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbackup.BackgroundImage")));
            this.btnbackup.ButtonText = "Backup DB";
            this.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.IdleBorderThickness = 1;
            this.btnbackup.IdleCornerRadius = 20;
            this.btnbackup.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbackup.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbackup.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.Location = new System.Drawing.Point(16, 148);
            this.btnbackup.Margin = new System.Windows.Forms.Padding(5);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(112, 41);
            this.btnbackup.TabIndex = 6;
            this.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Restore DB";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(138, 148);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(114, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnbrowe1
            // 
            this.btnbrowe1.ActiveBorderThickness = 1;
            this.btnbrowe1.ActiveCornerRadius = 20;
            this.btnbrowe1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.ActiveForecolor = System.Drawing.Color.White;
            this.btnbrowe1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbrowe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowe1.BackgroundImage")));
            this.btnbrowe1.ButtonText = "Restore Location";
            this.btnbrowe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowe1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.IdleBorderThickness = 1;
            this.btnbrowe1.IdleCornerRadius = 20;
            this.btnbrowe1.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbrowe1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.Location = new System.Drawing.Point(261, 108);
            this.btnbrowe1.Margin = new System.Windows.Forms.Padding(5);
            this.btnbrowe1.Name = "btnbrowe1";
            this.btnbrowe1.Size = new System.Drawing.Size(135, 41);
            this.btnbrowe1.TabIndex = 7;
            this.btnbrowe1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowe1.Click += new System.EventHandler(this.btnbrowe1_Click);
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
            this.prb.Location = new System.Drawing.Point(287, 156);
            this.prb.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.prb.MaxValue = 100;
            this.prb.Name = "prb";
            this.prb.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prb.ProgressColor = System.Drawing.Color.SeaGreen;
            this.prb.Size = new System.Drawing.Size(92, 92);
            this.prb.TabIndex = 26;
            this.prb.Value = 0;
            this.prb.Visible = false;
            // 
            // pntop
            // 
            this.pntop.BackColor = System.Drawing.Color.Black;
            this.pntop.Controls.Add(this.label3);
            this.pntop.Controls.Add(this.btnclose);
            this.pntop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntop.Location = new System.Drawing.Point(0, 0);
            this.pntop.Name = "pntop";
            this.pntop.Size = new System.Drawing.Size(421, 44);
            this.pntop.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "DB Backup System";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(344, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(71, 42);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblcmp
            // 
            this.lblcmp.AutoSize = true;
            this.lblcmp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmp.Location = new System.Drawing.Point(108, 205);
            this.lblcmp.Name = "lblcmp";
            this.lblcmp.Size = new System.Drawing.Size(0, 16);
            this.lblcmp.TabIndex = 28;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Last  Location";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 44);
            this.panel1.TabIndex = 30;
            // 
            // frmback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(421, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblcmp);
            this.Controls.Add(this.pntop);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnbrowe1);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtrestore);
            this.Controls.Add(this.BackupTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmback_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmback_KeyDown);
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox BackupTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtrestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbrowse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbackup;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbrowe1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prb;
        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblcmp;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;

    }
}