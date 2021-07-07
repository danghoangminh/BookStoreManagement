using System.Data;

namespace BookStoreManagement.Model
{
    public class Login
    {
        public bool isLogin(string username, string password)
        {
            string query = $"SELECT USERNAME, PASSWORD FROM ACCOUNT WHERE USERNAME = '{username}' AND PASSWORD = '{password}'";
            DataTable result = DBAccess.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}