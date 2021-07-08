using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Giao_dien_quan_ly_thu_vien.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        
        public static DataProvider Instance
        {
            get { if (instance == null) 
                    instance = new DataProvider(); 
                return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        

        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";


        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }


        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }


        public DataSet ExecuteQueryList(string query, object[] paramater = null)
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (paramater != null)
                {
                    string[] lisrPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisrPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
