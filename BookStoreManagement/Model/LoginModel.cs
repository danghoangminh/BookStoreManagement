using System.Data;

namespace BookStoreManagement.Model
{
    public class LoginModel
    {
        public string user;
        public string pwd;

        public LoginModel(string username, string password)
        {
            user = username;
            pwd = password;
        }

        public bool isLogin()
        {
            string query = $"SELECT USERNAME, PASSWORD FROM ACCOUNT WHERE USERNAME = '{user}' AND PASSWORD = '{pwd}'";
            DataTable result = DBAccess.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}