using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class VegBurger : Burger
    {
        public override float price()
        {
            return 25.0f;
        }
        public override String name()
        {
            return "Veg Burger";
        }
    }
}
