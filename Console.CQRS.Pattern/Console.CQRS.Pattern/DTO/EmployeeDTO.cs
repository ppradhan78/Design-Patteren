﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.DTO
{
    public class EmployeeDTO
    {
        public int Id
        {
            get;
            set;
        }
        public string FullName
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
    }
}
