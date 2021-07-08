using System.Data;
using System.Windows.Forms;

namespace BookStoreManagement.Model
{
    public class UserModel
    {
        string user;

        public UserModel(string username)
        {
            user = username;
        }

        public DataTable getUserInfo()
        {
            string query = $"SELECT * FROM ACCOUNT WHERE USERNAME = '{user}'";
            DataTable data = DBAccess.Instance.ExecuteQuery(query);
            return data;
        }

        public void updateUserInfo(string username, string password, string firstName, string lastName, string email, string phone)
        {
            string query = $"UPDATE ACCOUNT SET USERNAME = '{username}', PASSWORD = '{password}', FIRSTNAME = '{firstName}', LASTNAME = '{lastName}', EMAIL = '{email}', PHONE = '{phone}'";
            DBAccess.Instance.ExecuteNonQuery(query);
        }
    }
}
