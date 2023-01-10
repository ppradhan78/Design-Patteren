using BridgeDesignPattern.Abstraction;
using BridgeDesignPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextNotification textNotification = new TextNotification(new Email());
            textNotification.send();

            QRNotification QRNotification = new QRNotification(new Email());
            QRNotification.send();

            Console.ReadKey();
        }
    }
}
