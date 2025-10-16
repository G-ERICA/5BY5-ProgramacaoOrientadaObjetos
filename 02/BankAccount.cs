using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class BankAccount
    {
        private double Balance {  get; set; }
        private string? Holder { get; set; }


        public string SetHolder(string holder) 
        {
            return this.Holder = holder;
        }

        public string GetHolder() 
        {
            return this.Holder;        
        }

        private double SetBalance(double balance) 
        {
            return this.Balance = balance;
        }
        public double GetBalance() 
        {
            return this.Balance;
        }

        public double BankDeposity(double money) 
        {
            this.Balance = this.Balance + money;
            return this.Balance;
        }

        public void Withdrawals(double money) 
        {
            if (money <= this.Balance) 
            {
                this.Balance = this.Balance - money;
            }
            else
            {
                Console.WriteLine($"{money:C} é maior que o saldo disponível");               
            }
        }
    }
}
