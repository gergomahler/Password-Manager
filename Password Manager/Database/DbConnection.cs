using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Password_Manager.Database
{
    public static class DbConnection
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = Properties.Settings.Default.connection_string;
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public static DataTable GetDataTable (string SQLText)
        {
            SqlConnection connection = GetDBConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQLText, connection);
            adapter.Fill(table);

            return table;

        }

        public static void ExecuteSQL (string SQLText)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = new SqlCommand(SQLText, connection);
            command.ExecuteNonQuery();
        }

        public static void CloseDBConnection()
        {
            string connectionString = Properties.Settings.Default.connection_string;
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
