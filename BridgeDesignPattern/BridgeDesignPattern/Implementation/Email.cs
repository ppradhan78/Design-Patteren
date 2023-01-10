using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Implementation
{
    internal class Email : ISendNotification
    {
        public void SendNotification(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
