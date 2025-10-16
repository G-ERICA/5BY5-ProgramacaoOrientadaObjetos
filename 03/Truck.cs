using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public double SetLoudCapacity(double capacity) 
        {
            return this.LoadCapacity = capacity;
        }

        public double GetLoudCapacity() 
        {
            return this.LoadCapacity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Capacidade da Carga: {this.LoadCapacity}");
        }
    }
}
