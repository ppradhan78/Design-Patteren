using FactoryDesignPattern.Example1.Interface;
using FactoryDesignPattern.Example1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Example1.Factory
{
    public class CarFactory
    {
        public static ICarSupplier GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                //case 2:
                //    return new Nano();
                default:
                    return null;
            }
        }
    }
}
