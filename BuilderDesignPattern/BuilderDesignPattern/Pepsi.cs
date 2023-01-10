using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Pepsi : ColdDrink
    {
        public override float price()
        {
            return 35.0f;
        }
        public override String name()
        {
            return "Pepsi";
        }
    }
}
