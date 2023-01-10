using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.Models
{
    public class Employee
    {
        public int Id
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string Street
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string PostalCode
        {
            get;
            set;
        }
    }
}
