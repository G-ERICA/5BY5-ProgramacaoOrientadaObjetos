using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class PushNotification : Notification
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Notificação Push enviada!");
        }
    }
}

