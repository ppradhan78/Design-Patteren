using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class DbErrorLogger : AbstractLogger
    {
        public DbErrorLogger(int level)
        {
            this.level = level;
        }
        protected override void write(String message)
        {
            Console.WriteLine("Database Error ::Logger: " + message);
        }
    }
}
