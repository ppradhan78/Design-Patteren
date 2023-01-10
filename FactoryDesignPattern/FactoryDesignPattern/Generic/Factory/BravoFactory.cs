using FactoryDesignPattern.Generic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Generic.Factory
{
    public class BravoFactory : FactoryBase<BravoClass>
    {
        public override BravoClass Create()
        {
            return new BravoClass { Name = "Check this out" };
        }
    }
}
