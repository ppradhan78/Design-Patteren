using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class SplonkLogger : AbstractLogger
    {
        public SplonkLogger(int level)
        {
            this.level = level;
        }
        protected override void write(String message)
        {
            Console.WriteLine("Splonk ::Logger: " + message);
        }
    }
}
