using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.PatientFeed
{
    public class ODXPatientFeedProcesser : IProcessFeeds
    {
        public void ProcessFeed()
        {
            Console.WriteLine("ODX Patient Feed Processer");
        }
    }
}
