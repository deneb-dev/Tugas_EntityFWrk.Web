﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_API.Models
{
    public class User
    {
        public User (ViewModels.UserVM user)
        {
            this.Id = user.Id;
            this.Password = user.Password;
            this.Employee = Employee;
        }

        public User()
        {

        }

        [Key]
        [ForeignKey("Employee")]
        public int Id { get; private set; }
        public string Password { get; private set; }
        public Employee Employee { get; set; }
    }
}
