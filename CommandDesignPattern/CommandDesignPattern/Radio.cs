using CommandDesignPattern.Interface;
using System;

namespace CommandDesignPattern
{
    public class Radio : IElectronicDevice
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("Radio is off");
        }

        public void On()
        {
            Console.WriteLine("Radio is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("Radio volume  is at" + volume);
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("Radio volume  is at"+volume);
        }
    }
}
