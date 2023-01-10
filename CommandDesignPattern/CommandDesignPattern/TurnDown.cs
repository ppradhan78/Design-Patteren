using CommandDesignPattern.Interface;
using System;

namespace CommandDesignPattern
{
    public class TurnDown : ICommand
    {
        private IElectronicDevice electronicDevice;

        public TurnDown(IElectronicDevice device)
        {
            electronicDevice = device;
        }
        public void execute()
        {
            electronicDevice.volumeDown();
        }

        public void undo()
        {
            electronicDevice.volumeUp();
        }
    }
}
