using CommandDesignPattern.Interface;
using System;

namespace CommandDesignPattern
{
    public class Television : IElectronicDevice
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("TV volume  is at" + volume);
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("TV volume  is at"+volume);
        }
    }
}
