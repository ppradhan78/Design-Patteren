﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IItem
    {
        public String name();
        public IPacking packing();
        public float price();
    }
}
