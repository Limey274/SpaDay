﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {


        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AccountCreated { get; set; }

        public User() 
        {

            AccountCreated = DateTime.Now;
        }

        

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

    }
}
