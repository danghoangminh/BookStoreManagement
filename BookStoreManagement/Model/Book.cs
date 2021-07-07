using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Model
{
    public class Book
    {
        public DataTable LoadData()
        {
            string query = "SELECT BOOKID AS [Book ID], BOOKTITLE AS [Book Title], AUTHOR AS [Author], CATEGORY AS [Category], PUBLISHER AS [Publisher], COSTPRICE AS [Cost Price], SELLPRICE AS [Selling Price], QUANTITY AS [Quantity] FROM BOOK";
            DataTable data = DBAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
