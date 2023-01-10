using AbstractFactory.NLPFeed;
using AbstractFactory.PatientFeed;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class FeedFactoryProducer
    {
        public static PatentFeedFactory getFactory(String FeedType)
        {
            if (FeedType.Equals("NLP", StringComparison.OrdinalIgnoreCase))
            {
                return new NLPFeedProcesserFactory();
            }
            else if (FeedType.Equals("Patient", StringComparison.OrdinalIgnoreCase))
            {
                return new PatientFeedProcesserFactory();
            }
            return null;
        }
    }
}
