using BookStoreManagement.Forms;
using System;
using System.Windows.Forms;

namespace BookStoreManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (frmDashboard fd = new frmDashboard(txbUser.Text))
            {
                fd.ShowDialog();
            }
        }
    }
}