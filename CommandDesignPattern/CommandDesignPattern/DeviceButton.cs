using CommandDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class DeviceButton
    {
        ICommand command;
        public DeviceButton(ICommand _command)
        {
            command = _command;
        }
        public void press()
        {
            command.execute();
        }
        public void undo()
        {
            command.undo();
        }
    }
}
