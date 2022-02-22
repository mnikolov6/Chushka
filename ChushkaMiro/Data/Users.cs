﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChushkaMiro.Data
{
    public class Users
    {   [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public RolesType Role { get; set; }
        public ICollection<Orders> Order { get; set; }
    }
}
