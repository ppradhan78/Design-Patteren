using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }
        protected override void write(String message)
        {
            Console.WriteLine("Console::Logger: " + message);
        }
    }
}
