using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Example1.Interface
{
    public interface ICarSupplier
    {
        string CarColor {get;}
        void GetCarModel();
    }
}
