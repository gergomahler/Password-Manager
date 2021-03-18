using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Model
{
    class User
    {
        private int ID { get; set; }
        private string Username { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private List<Account> Accounts { get; set; }
    }
}
