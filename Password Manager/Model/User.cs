using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Model
{
    class User
    {
        public User()
        {
            Accounts = new List<Account>();
        }

        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
