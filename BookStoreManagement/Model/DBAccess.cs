using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BookStoreManagement.Model
{
    public class DBAccess
    {
        private static DBAccess instance;

        public static DBAccess Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBAccess();
                return DBAccess.instance;
            }
            private set { DBAccess.instance = value; }
        }

        private DBAccess() { }

        private string connectionString = "Data Source=E:\\quan-li-nha-sach\\BookStoreManagement\\Model\\database.sqlite;Version=3;";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
