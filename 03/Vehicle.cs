using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    abstract class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string SetBrand(string brand) 
        {
            return this.Brand = brand;
        }
        public string GetBrand() 
        {
            return this.Brand;
        }
        public string SetModel(string model) 
        {
            return this.Model = model;
        }
        public string GetModel() 
        {
            return this.Model;
        }

        public int SetYear(int year) 
        {
            return this.Year = year;
        }
        public int GetYear() 
        {
            return this.Year;
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Marca: {this.Brand}"); 
            Console.WriteLine($"Modelo: {this.Model}"); 
            Console.WriteLine($"Ano: {this.Year}");
        }
    }
}
