using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.FeedProcessor.MediTouch
{
    public interface IMediTouchPatentDataProcesser
    {
        void ReadData();
        void ProcessData();
    }
}
