﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Model
{
    class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
