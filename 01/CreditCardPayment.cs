using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class CreditCardPayment : Payment
    {
        public override void PaymentProcess(DateTime date, double value)
        { 
            this.SetAmount(value);
            this.SetPaymenteDate(date);

            Console.WriteLine($"Pagamento realizado com Cartão de Crédito! {value:C}\n\tData do pagamento: {date}");

        }
    }
}