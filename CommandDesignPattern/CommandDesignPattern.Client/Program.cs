﻿using CommandDesignPattern.StockExample;
using System;

namespace CommandDesignPattern.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
            Console.ReadKey();
        }
    }
}
