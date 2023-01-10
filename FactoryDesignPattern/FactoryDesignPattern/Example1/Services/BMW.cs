using FactoryDesignPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Example1.Services
{
    public class BMW : ICarSupplier
    {
        public string CarColor
        {
            get { return "WHITE"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine("BMW Car Model is BMW 2000");
        }
    }
}
