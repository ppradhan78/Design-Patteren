using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class Notification
    {
        protected ISendNotification _sendNotification;
        protected Notification(ISendNotification sendNotification)
        {
            this._sendNotification = sendNotification;
        }
        public abstract void send();
    }

}
