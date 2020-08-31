using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacAndAutoMapperMVC.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string MaritalStatus { get; set; }

        public string HighestEducation { get; set; }

    }
}