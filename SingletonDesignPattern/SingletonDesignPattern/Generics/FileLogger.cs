using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Generics
{
    public class FileLogger : GenericsSingleton<FileLogger>
    {
        private FileLogger() { }

        public new static FileLogger Instance
        {
            get
            {
                FileLogger.initializer(() =>
                {
                    Console.WriteLine("System: FileLogger Singleton Initialized");
                    return new FileLogger();
                });
                return GenericsSingleton<FileLogger>.Instance;
            }
        }

        public void Logg(string m) { Console.WriteLine("Logg from FileLogger; " + m); }
    }
}
