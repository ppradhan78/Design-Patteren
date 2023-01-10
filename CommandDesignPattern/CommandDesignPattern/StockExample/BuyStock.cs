using CommandDesignPattern.StockExample.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.StockExample
{
    //Create concrete classes implementing the Order interface.
    public class BuyStock : IOrder
    {
        private Stock abcStock;
        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public void execute()
        {
            abcStock.buy();
        }
    }
}
