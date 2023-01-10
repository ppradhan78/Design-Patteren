using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.OrderProcessing
{
    public class StoreOrder : OrderProcessTemplate
    {


        public override void doSelect()
        {
            Console.WriteLine("Customer chooses the item from shelf.");
        }

        public override void doPayment()
        {
            Console.WriteLine("Pays at counter through cash/POS");
        }

        public override void doDelivery()
        {
            Console.WriteLine("Item delivered to in delivery counter.");
        }

    }
}

