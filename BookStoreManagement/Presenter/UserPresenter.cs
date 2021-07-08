using System.Data;
using System.Windows.Forms;
using BookStoreManagement.Model;

namespace BookStoreManagement.Presenter
{
    public class UserPresenter
    {
        public string user;
        public string pwd;
        public string firstName;
        public string lastName;
        public string email;
        public string phone;

        UserModel userModel;

        public UserPresenter(string username)
        {
            user = username;

            userModel = new UserModel(user);
            DataTable userData = userModel.getUserInfo();

            pwd = userData.Rows[0]["PASSWORD"].ToString();
            firstName = userData.Rows[0]["FIRSTNAME"].ToString();
            lastName = userData.Rows[0]["LASTNAME"].ToString();
            email = userData.Rows[0]["EMAIL"].ToString();
            phone = userData.Rows[0]["PHONE"].ToString();
        }

        public void saveUserData(string username, string password, string firstName, string lastName, string email, string phone)
        {
            if (username != null && password != null && firstName != null && lastName != null && email != null && phone != null)
            {
                userModel.updateUserInfo(username, password, firstName, lastName, email, phone);
            }
            else
            {
                MessageBox.Show("CHƯA ĐIỀN ĐẦY ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
        }
    }
}
