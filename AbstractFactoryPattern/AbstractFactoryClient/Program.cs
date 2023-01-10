using AbstractFactory.Factory;
using AbstractFactory.FactoryInterface;
using System;

namespace AbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {


            PatentFeedFactory shapeFactory = FeedFactoryProducer.getFactory("Patient");

            //get an object of PatientFeed AllScript
            IProcessFeeds shape1 = shapeFactory.ProcessFeed("AllScript");
            //call ProcessFeed  method of PatientFeed AllScript
            shape1.ProcessFeed();

            //get an object of PatientFeed NDSC
            IProcessFeeds shape2 = shapeFactory.ProcessFeed("NDSC");
            //call ProcessFeed  method of PatientFeed AllScript
            shape2.ProcessFeed();


            PatentFeedFactory shapeFactory1 = FeedFactoryProducer.getFactory("NLP");

            //get an object of NLP AllScript
            IProcessFeeds shape3 = shapeFactory1.ProcessFeed("AllScript");
            //call ProcessFeed  method of NLP AllScript
            shape3.ProcessFeed();

            //get an object of PatientFeed NDSC
            IProcessFeeds shape4 = shapeFactory1.ProcessFeed("NDSC");
            //call ProcessFeed  method of NLP  AllScript
            shape4.ProcessFeed();

            //get an object of PatientFeed NDSC
            IProcessFeeds shape4 = shapeFactory1.ProcessFeed("ODX");
            //call ProcessFeed  method of NLP  AllScript
            shape4.ProcessFeed();


            Console.ReadLine();

        }
    }
}
