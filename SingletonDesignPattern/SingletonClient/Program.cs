using SingletonDesignPattern;
using SingletonDesignPattern.Generics;
using System;

namespace SingletonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("hi");
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("hello");

            //DBLogger.Instance.Logg("test DBLogger");
            //DBLogger.Instance.Logg("hello DBLogger");
            //FileLogger.Instance.Logg("hello FileLogger");
            //DBLogger.Instance.Logg("hello DBLogger again");

            int number = 153;
            int temp = number;
            int rem = 0, sum = 0;
            while (number > 0)
            {
                rem = number % 10;
                number = number / 10;
                sum = sum + (rem * rem * rem);

            }
            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");

          var output=  Fib(5);
            Console.WriteLine(output + " output");
        }
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

    }
}
