﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : Entity<int>
    {
        public Customer() { }
        public int UserId { get; set; }
        public Customer(int userId) 
        {
            UserId = userId;
        }
        public User? User { get; set; } = null;
    }
}
