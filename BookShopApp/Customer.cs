﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Customer () { }

        //public Customer (string name, string address, string email)
        //{
        //    Name = name;
        //    Address = address;
        //    Email = email;
        //}
    }
}
