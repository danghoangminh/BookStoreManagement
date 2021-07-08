using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Model
{
    public class AuthorModel
    {
        public void AddAuthor(string fullname, string place, string birth, string death)
        {
            string query = $"INSERT INTO AUTHOR VALUES ('{fullname}', '{birth}','{death}', '{place}')";
            DBAccess.Instance.ExecuteNonQuery(query);
        }
    }
}
