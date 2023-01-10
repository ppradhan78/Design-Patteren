using FactoryDesignPattern.Generic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Generic.Factory
{
   public class AlphaFactory : FactoryBase<AlphaClass>
    {
        public override AlphaClass Create()
        {
            return new AlphaClass { Description = "Hello world" };
        }
    }
}
