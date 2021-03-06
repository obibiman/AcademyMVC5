﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Core
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string NationalIdNumber { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }   
    }
}
