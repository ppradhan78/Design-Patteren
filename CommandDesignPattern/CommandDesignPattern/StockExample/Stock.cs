using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.StockExample
{
    //Create a request class.
    public class Stock
    {
        private String name = "ABC";
        private int quantity = 10;
        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity +" ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity +" ] sold");
        }
    }
}
