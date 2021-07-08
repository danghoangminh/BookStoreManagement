using Giao_dien_quan_ly_thu_vien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Giao_dien_quan_ly_thu_vien.Resources
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO()
        { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWord";  // must have a space between the parameter and the ','
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
    }
}