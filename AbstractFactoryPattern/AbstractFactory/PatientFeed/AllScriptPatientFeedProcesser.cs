using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.PatientFeed
{
    public class AllScriptPatientFeedProcesser : IProcessFeeds
    {
        public void ProcessFeed()
        {
            Console.WriteLine("AllScript Patient Feed Processer");
        }
    }
}
