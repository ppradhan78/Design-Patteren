using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class ApplicationInsightsLogger : AbstractLogger
    {

        public ApplicationInsightsLogger(int level)
        {
            this.level = level;
        }

        protected override void write(String message)
        {
            Console.WriteLine("Application Insights Logger::Logger: " + message);
        }
    }
}
