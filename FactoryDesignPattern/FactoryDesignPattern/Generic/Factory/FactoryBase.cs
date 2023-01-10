using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Generic.Factory
{
    public class FactoryBase<T>
    {
        public virtual T Create() { return default(T); }
    }
}
