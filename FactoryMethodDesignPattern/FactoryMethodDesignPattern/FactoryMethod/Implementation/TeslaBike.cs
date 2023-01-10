using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryMethod
{
    public class TeslaBike : IVehicle
    {
        public void Manufacture()
        {
            Console.WriteLine("TeslaBike");
        }
    }
}