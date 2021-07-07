using System;
using System.Windows.Forms;
using BookStoreManagement.Forms;
using BookStoreManagement.Model;

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
            Login login = new Login();
            
            if(login.isLogin(txbUser.Text, txbPassword.Text))
            {
                frmDashboard fd = new frmDashboard(txbUser.Text);
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("SAI TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU!", "THÔNG BÁO");
            }
        }
    }
}