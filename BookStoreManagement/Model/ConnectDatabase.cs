using System.Data.SQLite;

namespace BookStoreManagement.Model
{
    class ConnectDatabase
    {
        SQLiteConnection connection = new SQLiteConnection();
        
        public void createConection()
        {
            string strConnect = "Data Source = database.sqlite";
            connection.ConnectionString = strConnect;
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
