using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Motorcicle : Vehicle
    {
        public int PreviousOwners { get; set; }
        public string GasType { get; set; }

        public int SetPreviousOwners(int owners) 
        {
            return this.PreviousOwners = owners;
        }

        public string SetGasType(string gas) 
        {
            return this.GasType = gas;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Donos anteriores: {this.PreviousOwners}");
            Console.WriteLine($"Tipo de Combustível: {this.GasType}");
        }
    }
}
