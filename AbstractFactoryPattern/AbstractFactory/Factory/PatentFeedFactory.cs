using AbstractFactory.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public abstract class PatentFeedFactory
    {
       public  abstract IProcessFeeds ProcessFeed(String  FeedType);
    }
}
