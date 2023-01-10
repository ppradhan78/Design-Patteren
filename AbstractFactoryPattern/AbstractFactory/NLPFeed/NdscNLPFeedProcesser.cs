using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.NLPFeed
{
    public class NdscNLPFeedProcesser : IProcessFeeds
    {
        public void ProcessFeed()
        {
            Console.WriteLine("NDSC NLP Feed Processer");
        }
    }
}
