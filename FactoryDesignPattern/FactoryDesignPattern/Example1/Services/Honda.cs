using FactoryDesignPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Example1.Services
{
   public class Honda : ICarSupplier
    {
        public string CarColor
        {
            get { return "RED"; }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
}
