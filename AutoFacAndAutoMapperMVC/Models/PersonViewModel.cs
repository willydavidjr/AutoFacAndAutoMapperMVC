using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacAndAutoMapperMVC.Models
{
    public class PersonViewModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Country { get; set; }

        public string MaritalStatus { get; set; }

        public string HighestEducation { get; set; }
    }
}