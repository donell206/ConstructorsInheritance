using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionDemo.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; }
        //public DateTime DateOfBirth { get; set; }
        public string School { get; set; }
        public Address Address { get; set; } //composition
    }
}
