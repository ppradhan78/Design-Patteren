using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.FeedProcessor.MediTouch
{
    public class MediTouchPatentDataProcesser : PatentDataProcesser,IMediTouchPatentDataProcesser
    {
        public override void ReadData()
        {
            Console.WriteLine("Read the MediTouch Patent Data  ");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process the MediTouch Patent Data  ");
        }
    }
}
