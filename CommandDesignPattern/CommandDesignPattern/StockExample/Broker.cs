using CommandDesignPattern.StockExample.Interface;
using System.Collections.Generic;

namespace CommandDesignPattern.StockExample
{
    //Create command invoker class.
    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();
        public void takeOrder(IOrder order)
        {
            orderList.Add(order);
        }
        public void placeOrders()
        {
            foreach (var item in orderList)
            {
                item.execute();
            }
            orderList.Clear();
        }
    }
}
