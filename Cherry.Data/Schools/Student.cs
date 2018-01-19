﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cherry.Data.Schools
{
    public class Student
    {
        [Column(TypeName = "char(36)")]
        [Key]
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = Guid.NewGuid().ToString();
            }
        }
        private string _id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string Login { get; set; }
        public string PasswordHash { get; set; }

        public DateTime LastLogin { get; set; }
        public DateTime LastFullLogin { get; set; }
        public bool IsLocked { get; set; }
    }
}
