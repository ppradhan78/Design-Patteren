using System;

namespace SingletonDesignPattern
{
     //*  Sealed restricts the inheritance
    public sealed class LazySingleton
    {
        private static int counter = 0;

        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<LazySingleton> instance =
new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
