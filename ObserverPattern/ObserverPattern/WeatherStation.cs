using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherStation : ISubject
    {
        public float _temperature;
        private List<IObserver> observers;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public float Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                Notify();
            }
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Update(this));
        }
    }
}
