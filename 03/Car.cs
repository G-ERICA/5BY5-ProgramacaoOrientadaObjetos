using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Car : Vehicle
    {
        public int DoorsNumber { get; set; }
        public string GasType { get; set; }

        public int SetDoorsNumber(int doors) 
        { 
            return this.DoorsNumber = doors;
        }

        public int GetDoorsNumber() 
        {
            return this.DoorsNumber;
        }

        public string SetGasType(string gas) 
        { 
            return this.GasType = gas;
        }

        public string GetGasType()
        {
            return this.GasType;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Número de portas: {this.DoorsNumber}");
            Console.WriteLine($"Tipo de Combustível: {this.GasType}");
        }
    }
}
