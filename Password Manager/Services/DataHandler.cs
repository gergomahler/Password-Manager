using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Manager.Database;
using System.Data;
using System.Data.SqlClient;
using Password_Manager.Model;

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
            command.CommandText = "INSERT INTO [User] (email, username, password)" + "VALUES('" + email + "','" + username + "','" + password + "')";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public User Login (string username, string password)
        {
            User user = new User();

            command.CommandText = "SELECT Id, username FROM [User] WHERE username='" + username + "'";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            reader = command.ExecuteReader();
            if (reader["Password"].ToString() == password)
            {
                user.ID = (int)reader["Id"];
                user.Username = reader["username"].ToString();
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();
            connection.Close();


            return user;
        }

        public List<Account> GetUserAccounts (int userId)
        {
            List<Account> accounts = new List<Account>();

            command.CommandText = "SELECT * FROM [Account] WHERE userID= '" + userId + "'";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            reader = command.ExecuteReader();


            return accounts;
        }
    }
}
