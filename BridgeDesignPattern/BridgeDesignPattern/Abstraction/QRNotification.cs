using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Abstraction
{
    internal class QRNotification : Notification
    {
        public QRNotification(ISendNotification sendNotification):base(sendNotification)  
        {

        }
        public override void send()
        {
            this._sendNotification.SendNotification("QR");
        }
    }
}
