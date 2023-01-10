using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public abstract class Burger : IItem
    {
        
        public IPacking packing()
        {
            return new Wrapper();
        }
        public abstract float price();
        public abstract string name();
    }
}
