using System;
using TemplateMethodPattern.FeedProcessor.AllScripts;
using TemplateMethodPattern.FeedProcessor.MediTouch;
using TemplateMethodPattern.OrderProcessing;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AllScriptPatentDataProcesser allscript = new AllScriptPatentDataProcesser();
            allscript.ProcessPatentData();
            Console.WriteLine("******************************************");
            MediTouchPatentDataProcesser midTouch = new MediTouchPatentDataProcesser();
            midTouch.ProcessPatentData();
            Console.WriteLine("######################################");
            //--##############################################
            OrderProcessTemplate netOrder = new NetOrder();
            netOrder.processOrder(true);
            Console.WriteLine("*****************************************");
            OrderProcessTemplate storeOrder = new StoreOrder();
            storeOrder.processOrder(true);
            Console.WriteLine("######################################");
            DataAccessor categories = new Categories();
            categories.Run(5);
            Console.WriteLine("******************************************");
            DataAccessor products = new Products();
            products.Run(3);

            Console.ReadKey();
        }
    }
}
