using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency newsAgency = new NewsAgency("A");
            weatherStation.Attach(newsAgency);

            NewsAgency newsAgency1 = new NewsAgency("B");
            weatherStation.Attach(newsAgency1);

            NewsAgency newsAgency2 = new NewsAgency("C");
            weatherStation.Attach(newsAgency2);

            weatherStation.Temperature = 31.2f;
            var flot = Console.ReadLine();
            weatherStation.Temperature = float.Parse(flot, CultureInfo.InvariantCulture.NumberFormat);

            Console.ReadLine();
        }
    }
}
