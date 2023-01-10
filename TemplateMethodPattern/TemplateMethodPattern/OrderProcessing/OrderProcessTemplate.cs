using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.OrderProcessing
{
    public abstract class OrderProcessTemplate
    {
        public bool isGift;

        public abstract void doSelect();

        public abstract void doPayment();
        public abstract void doDelivery();
        public  void giftWrap()
        {
            try
            {
                Console.WriteLine("Gift wrap successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Gift wrap unsuccessful");
            }
        }

        public   void processOrder(bool isGift)
        {
            doSelect();
            doPayment();
            if (isGift)
            {
                giftWrap();
            }
            doDelivery();
        }
    }
}
