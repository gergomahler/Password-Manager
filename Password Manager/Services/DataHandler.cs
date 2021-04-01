using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Manager.Database;
using System.Data;
using System.Data.SqlClient;

namespace Password_Manager.Services
{
    class DataHandler
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connection_string);
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public void RegisterNewUser (string email, string username, string password)
        {
            command.CommandText = "INSERT INTO [User] (Email, Username, Password)" + "VALUES('" + email + "','" + username + "','" + password + "')";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            /*string sqlQuery = "INSERT INTO [User] (Email, Username, Password) " +
                             "VALUES('" + email + "','" + username + "','" + password + "')";

            DbConnection.ExecuteSQL(sqlQuery);*/
        }
    }
}
