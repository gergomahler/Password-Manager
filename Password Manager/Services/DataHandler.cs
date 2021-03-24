using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password_Manager.Database;

namespace Password_Manager.Services
{
    class DataHandler
    {
        public void RegisterNewUser (string email, string username, string password)
        {
            string sqlQuery = "INSERT INTO [User] (Email, Username, Password) " +
                             "VALUES('" + email + "','" + username + "','" + password + "')";

            DbConnection.ExecuteSQL(sqlQuery);
        }
    }
}
