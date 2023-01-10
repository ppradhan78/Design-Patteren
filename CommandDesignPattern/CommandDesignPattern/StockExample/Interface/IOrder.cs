using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.StockExample.Interface
{
    //Create a command interface.
    public interface IOrder
    {
        void execute();
    }
}
