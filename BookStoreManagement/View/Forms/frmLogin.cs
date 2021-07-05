using BookShopManagement.Forms;
using System;
using System.Windows.Forms;

namespace BookShopManagement
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (Form_Dashboard fd = new Form_Dashboard())
            {
                fd.ShowDialog();
            }
        }
    }
}
