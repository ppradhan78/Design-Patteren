using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.FeedProcessor.AllScripts
{
    public interface IAllScriptPatentDataProcesser
    {
        void ReadData();
        void ProcessData();
    }
}
