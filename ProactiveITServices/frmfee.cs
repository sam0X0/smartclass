using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProactiveITServices
{
    public partial class frmfee : Form
    {
        public frmfee()
        {
            InitializeComponent();
        }

        private void frmfee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feeslist.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.feeslist.DataTable1);
            // TODO: This line of code loads data into the 'feeslist.DataTable1' table. You can move, or remove it, as needed.
              // this.DataTable1TableAdapter.Fill(this.feeslist.DataTable1);
            // TODO: This line of code loads data into the 'feeslist.DataTable1' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void frmfee_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
