using AbstractFactory.Factory;
using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactory.NLPFeed
{
    public class NLPFeedProcesserFactory : PatentFeedFactory
    {
        public override IProcessFeeds ProcessFeed(String FeedType)
        {
            if (FeedType.Equals("AllScript", StringComparison.OrdinalIgnoreCase))
            {
                return new AllScriptNLPFeedProcesser();
            }
            else if (FeedType.Equals("NDSC", StringComparison.OrdinalIgnoreCase))
            {
                return new NdscNLPFeedProcesser();
            }
            return null;
        }
    }
}
