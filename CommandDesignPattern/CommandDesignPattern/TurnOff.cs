using CommandDesignPattern.Interface;

namespace CommandDesignPattern
{
    public class TurnOff : ICommand
    {
        private IElectronicDevice electronicDevice;

        public TurnOff(IElectronicDevice device)
        {
            electronicDevice = device;
        }
        public void execute()
        {
            electronicDevice.Off();
        }

        public void undo()
        {
            electronicDevice.On();
        }
    }
}
