using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.FeedProcessor
{
    public abstract class PatentDataProcesser  
    {
        public void ProcessPatentData()
        {
            PatentDataValidationAndVerification();
            ReadData();
            ProcessData();
            Savedata();
        }
        /// <summary>
        /// Own Implementation
        /// </summary>
        public abstract void ReadData();
        /// <summary>
        /// Own Implementation
        /// </summary>
        public abstract void ProcessData();
        private void Savedata()
        {
            Console.WriteLine("Patent Data Saved ! ");
        }

        private void PatentDataValidationAndVerification()
        {
            Console.WriteLine("Patent Data Validation And Verification completed.");
        }
    }
}
