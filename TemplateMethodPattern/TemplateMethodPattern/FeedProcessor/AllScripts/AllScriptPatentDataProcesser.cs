using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.FeedProcessor.AllScripts
{
    public class AllScriptPatentDataProcesser : PatentDataProcesser,IAllScriptPatentDataProcesser
    {
        public override void ReadData()
        {
            Console.WriteLine("Read the All Script Patent Data  ");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process the All Script Patent Data  ");
        }

    }
}
