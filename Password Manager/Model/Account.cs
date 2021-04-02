using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Model
{
    class Account
    {
        public Account()
        {
            ID = 0;
            URL = "";
            Email = "";
            Username = "";
            Password = "";
        }

        public int ID { get; set; }
        public string URL { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
