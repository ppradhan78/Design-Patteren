﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SampleModel
{
    public  class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
