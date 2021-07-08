using System.Data;

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

        public void AddBook(string bookid, string title, string author, string category, string publisher, int costprice, int sellprice, int quantity = 1)
        {
            string query = $"INSERT INTO BOOK VALUES ('{bookid}', '{title}', '{author}','{category}','{publisher}','{costprice}','{sellprice}','{quantity}')";
            DBAccess.Instance.ExecuteNonQuery(query);
        }

        public void AddItem(string item, string column)
        {
            string query = $"INSERT INTO {column} VALUES ('{item}')";
            DBAccess.Instance.ExecuteNonQuery(query);
        }

        public DataTable LoadList(string table, string column)
        {
            string query = $"SELECT {column} AS {table} FROM {table}";
            DataTable data = DBAccess.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
