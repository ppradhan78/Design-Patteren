using CommandDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class TVRemote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television();
        }
    }
}
