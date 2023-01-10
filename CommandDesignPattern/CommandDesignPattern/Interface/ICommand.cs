using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Interface
{
    public interface ICommand
    {
        public void execute();
        public void undo();
    }
}
