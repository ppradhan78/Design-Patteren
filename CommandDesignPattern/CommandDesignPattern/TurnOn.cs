using CommandDesignPattern.Interface;
using System;

namespace CommandDesignPattern
{
    public class TurnOn : ICommand
    {
        private IElectronicDevice electronicDevice;

        public TurnOn(IElectronicDevice device)
        {
            electronicDevice = device;
        }
        public void execute()
        {
            electronicDevice.On();
        }
        public void undo()
        {
            electronicDevice.Off();
        }

    }
}
