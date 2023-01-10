using CommandDesignPattern.Interface;
using System;

namespace CommandDesignPattern
{
    public class TurnUp : ICommand
    {
        private IElectronicDevice electronicDevice;

        public TurnUp(IElectronicDevice device)
        {
            electronicDevice = device;
        }
        public void execute()
        {
            electronicDevice.volumeUp();
        }
        public void undo()
        {
            electronicDevice.volumeDown();
        }

    }
}
