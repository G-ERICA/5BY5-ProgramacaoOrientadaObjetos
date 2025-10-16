using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public abstract class Notification
    {
        public virtual void Send(string message) 
        { 
            Console.WriteLine($"Enviando mensagem: {message}");
        }
    }
}
