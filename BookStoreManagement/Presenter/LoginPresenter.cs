using System.Windows.Forms;
using BookStoreManagement.Model;
using BookStoreManagement.Forms;

namespace BookStoreManagement.Presenter
{
    public class LoginPresenter
    {
        public LoginPresenter(string username, string password)
        {
            LoginModel login = new LoginModel(username, password);

            if (login.isLogin())
            {
                frmDashboard fd = new frmDashboard(username);
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("SAI TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU!", "THÔNG BÁO");
            }
        }
    }
}