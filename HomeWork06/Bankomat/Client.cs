﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06.Bankomat
{
    public class Client
    {
        public string Name { get;}
        public string Password { get;}
        public Client(string name, string password)
        {
            Name = name;
                Password = password;
        }
    }
}
