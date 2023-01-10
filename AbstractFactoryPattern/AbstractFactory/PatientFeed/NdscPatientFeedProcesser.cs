using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.PatientFeed
{
    public class NdscPatientFeedProcesser : IProcessFeeds
    {
        public void ProcessFeed()
        {
            Console.WriteLine("NDSC Patient Feed Processer");
        }
    }
}
