//using CommandDesignPattern.Interface;
//using System;
//using System.Collections.Generic;

//namespace CommandDesignPattern.Client
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IElectronicDevice device = TVRemote.getDevice();
//            TurnOn command = new TurnOn(device);
//            DeviceButton onPress = new DeviceButton(command);
//            onPress.press();

//            TurnOff offcommand = new TurnOff(device);
//             onPress = new DeviceButton(offcommand);
//            onPress.press();

//            TurnUp upcommand = new TurnUp(device);
//            onPress = new DeviceButton(upcommand);
//            onPress.press();
//            onPress.press();
//            onPress.press();


//            TurnDown downcommand = new TurnDown(device);
//            onPress = new DeviceButton(downcommand);
//            onPress.press();


//            Television tv = new Television();
//            Radio radio = new Radio();
//            List<IElectronicDevice> alldevice = new List<IElectronicDevice>();
//            alldevice.Add(tv);
//            alldevice.Add(radio);

//            TurnOffAll _turnOffAll = new TurnOffAll(alldevice);
//            DeviceButton _deviceButtonOff = new DeviceButton(_turnOffAll);
//            _deviceButtonOff.press();

//            _deviceButtonOff.undo();
//            Console.ReadKey();
//        }
//    }
//}
