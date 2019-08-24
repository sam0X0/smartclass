namespace ProactiveITServices
{
    partial class stdlist
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stdlist));
            this.stdregBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proactiveDataSet = new ProactiveITServices.proactiveDataSet();
            this.pntop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stdregTableAdapter = new ProactiveITServices.proactiveDataSetTableAdapters.stdregTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.stdregBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proactiveDataSet)).BeginInit();
            this.pntop.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdregBindingSource
            // 
            this.stdregBindingSource.DataMember = "stdreg";
            this.stdregBindingSource.DataSource = this.proactiveDataSet;
            // 
            // proactiveDataSet
            // 
            this.proactiveDataSet.DataSetName = "proactiveDataSet";
            this.proactiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pntop
            // 
            this.pntop.BackColor = System.Drawing.Color.Black;
            this.pntop.Controls.Add(this.label1);
            this.pntop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntop.Location = new System.Drawing.Point(0, 0);
            this.pntop.Name = "pntop";
            this.pntop.Size = new System.Drawing.Size(501, 45);
            this.pntop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Detail";
            // 
            // stdregTableAdapter
            // 
            this.stdregTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.stdregBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProactiveITServices.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(501, 255);
            this.reportViewer1.TabIndex = 5;
            // 
            // stdlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 300);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pntop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "stdlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stdlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdregBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proactiveDataSet)).EndInit();
            this.pntop.ResumeLayout(false);
            this.pntop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pntop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource stdregBindingSource;
        private proactiveDataSet proactiveDataSet;
        private proactiveDataSetTableAdapters.stdregTableAdapter stdregTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}