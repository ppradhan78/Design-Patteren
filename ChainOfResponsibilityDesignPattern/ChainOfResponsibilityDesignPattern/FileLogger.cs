using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override void write(String message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
