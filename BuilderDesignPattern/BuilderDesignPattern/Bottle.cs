using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Bottle : IPacking
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}
