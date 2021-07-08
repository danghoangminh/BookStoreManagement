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

        public void AddItem(string item, string table)
        {
            string query = $"INSERT INTO {table} VALUES ('{item}')";
            DBAccess.Instance.ExecuteNonQuery(query);
        }

        public DataTable LoadList(string table, string column)
        {
            string query = $"SELECT {column} AS {table} FROM {table}";
            DataTable data = DBAccess.Instance.ExecuteQuery(query);
            return data;
        }

        public string LoadItem(string column, string table, string name, string id)
        {
            string query = $"SELECT {column} FROM {table} WHERE {name} = '{id}';";
            var data = DBAccess.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0][column].ToString();
            }
            else
            {
                return "";
            }
        }

        public void AddQty(string table, string column, int value, string idCol, string id)
        {
            string query = $"UPDATE {table} SET {column} = {value} WHERE {idCol} = '{id}'";
            DBAccess.Instance.ExecuteNonQuery(query);
        }
    }
}
