﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.OrderProcessing
{
    class NetOrder : OrderProcessTemplate
    {

        public override void doSelect()
        {

            Console.WriteLine("Item added to online shopping cart");
            Console.WriteLine("Get gift wrap preference");
            Console.WriteLine("Get delivery address.");
        }


        public override void doPayment()
        {
            Console.WriteLine
                       ("Online Payment through Netbanking, card or Paytm");
        }


        public override void doDelivery()
        {
            Console.WriteLine
                        ("Ship the item through post to delivery address");
        }

    }
}
