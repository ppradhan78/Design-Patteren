using System;

namespace ChainOfResponsibilityDesignPattern.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainOfLoggers();

            //loggerChain.logMessage(AbstractLogger.INFO, "This is an information.");
            //loggerChain.logMessage(AbstractLogger.DEBUG, "This is an debug level information.");
            loggerChain.logMessage(AbstractLogger.ERROR, "This is an error information.");
            Console.ReadKey();
        }
        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger dbErrorLogger = new DbErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.ERROR);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.ERROR);
            AbstractLogger elmahLogger = new ElmahLogger(AbstractLogger.ERROR);
            AbstractLogger splonkLogger = new SplonkLogger(AbstractLogger.ERROR);

            //AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            //fileLogger.setNextLogger(consoleLogger);

            dbErrorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);
            consoleLogger.setNextLogger(elmahLogger);
            elmahLogger.setNextLogger(splonkLogger);

            return dbErrorLogger;
        }
    }

}
