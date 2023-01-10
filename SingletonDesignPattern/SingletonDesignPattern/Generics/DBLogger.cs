using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Generics
{
 
    public class DBLogger : GenericsSingleton<DBLogger>
    {
        private DBLogger() { }

        public new static DBLogger Instance
        {
            get
            {
                DBLogger.initializer(() =>
                {
                    Console.WriteLine("System: DBLogger Singleton Initialized");
                    return new DBLogger();
                });
                return GenericsSingleton<DBLogger>.Instance;
            }
        }

        public void Logg(string m) { Console.WriteLine("Logg from DBLogger; " + m); }
    }
}
