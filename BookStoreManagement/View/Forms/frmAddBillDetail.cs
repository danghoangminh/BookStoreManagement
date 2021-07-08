using System;
using System.Windows.Forms;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddBillDetail : Form
    {
        public frmAddBillDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
