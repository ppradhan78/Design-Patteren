using FactoryDesignPattern.Generic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Generic.Factory
{
    public class FactoryManager
    {
        public static FactoryBase<T> GetFactoryFor<T>() // The "Service Locator" method
        {
            if (typeof(T) == typeof(AlphaClass))
            {
                return (FactoryBase<T>)((object)new AlphaFactory());
            }
            else if (typeof(T) == typeof(BravoClass))
            {
                return (FactoryBase<T>)((object)new BravoFactory());
            }
            else
            {
                throw new ArgumentException("No factory defined for type " + typeof(T));

            }
        }
    }
}
