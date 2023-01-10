using AbstractFactory.Factory;
using AbstractFactory.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PatientFeed
{
    public class PatientFeedProcesserFactory : PatentFeedFactory
    {
        public override IProcessFeeds ProcessFeed(String FeedType)
        {
            if (FeedType.Equals("AllScript",StringComparison.OrdinalIgnoreCase))
            {
                return new AllScriptPatientFeedProcesser();
            }
            else if (FeedType.Equals("NDSC", StringComparison.OrdinalIgnoreCase))
            {
                return new NdscPatientFeedProcesser();
            }
            return null;
        }
    }
}
