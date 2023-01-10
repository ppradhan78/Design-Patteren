using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.NLPFeed
{
    public class AllScriptNLPFeedProcesser : IProcessFeeds
    {
        public void ProcessFeed()
        {
            Console.WriteLine("AllScript NLP Feed Processer");
        }
    }
}
