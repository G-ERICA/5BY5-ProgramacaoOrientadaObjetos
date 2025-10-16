using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    abstract class Payment
    {
        private double Amount { get; set; }
        private DateTime PaymentDate { get; set; }

        public void SetAmount(double amount) 
        {
            this.Amount = amount;
        }

        public void SetPaymenteDate(DateTime date)
        {
            this.PaymentDate = date;
        }

        public abstract void PaymentProcess(DateTime data, double valor);            

    }



}
