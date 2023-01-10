using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class ElmahLogger : AbstractLogger
    {
        public ElmahLogger(int level)
        {
            this.level = level;
        }
        protected override void write(String message)
        {
            Console.WriteLine("Elmah ::Logger: " + message);
        }
    }
}
