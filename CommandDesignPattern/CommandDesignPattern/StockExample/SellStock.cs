using CommandDesignPattern.StockExample.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.StockExample
{
    public class SellStock : IOrder
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public void execute()
        {
            abcStock.sell();
        }
    }
}
