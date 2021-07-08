using System.Windows.Forms;
using BookStoreManagement.Model;
using BookStoreManagement.View.Forms;

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
                MessageBox.Show("WRONG USERNAME OR PASSWORD!", "NOFICATION");
            }
        }
    }
}