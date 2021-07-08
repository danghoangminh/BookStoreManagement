using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Model
{
    public class BookModel
    {
        public DataTable LoadData()
        {
            string query = "SELECT * FROM BOOK";
            DataTable data = DBAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
