using CommandDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class TurnOffAll : ICommand
    {
        List<IElectronicDevice> devics;
        public TurnOffAll(List<IElectronicDevice> _devics)
        {
            devics = _devics;
        }
        public void execute()
        {
            foreach (var item in devics)
            {
                item.Off();
            }
        }

        public void undo()
        {
            foreach (var item in devics)
            {
                item.On();
            }
        }
    }
}
