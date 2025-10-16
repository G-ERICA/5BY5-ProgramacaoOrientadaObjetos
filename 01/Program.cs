/* 1.Abstração – Sistema de Pagamentos
Objetivo: praticar a criação de classes abstratas e métodos genéricos.
Descrição: 
Crie uma classe abstrata chamada Pagamento com:
Propriedades: Valor, DataPagamento.
Método abstrato ProcessarPagamento().
Crie duas classes que herdem de Pagamento: PagamentoCartaoCredito e PagamentoBoleto.
Cada uma deve implementar o método ProcessarPagamento() de forma diferente.
No programa principal (Main), simule o processamento de diferentes tipos de pagamento. */


using _01;

Console.WriteLine("Informe um valor a ser pago?");
var value = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a forma de pagamento: 1 - Boleto ou 2 - Cartão de Crédito");
var paymentMethod = Convert.ToInt32(Console.ReadLine()!);

if (paymentMethod == 1) 
{
    Payment payments = new BankSlip();
    payments.PaymentProcess(DateTime.Now, value);

}
else if(paymentMethod == 2)
{
    Payment payments = new CreditCardPayment();
    payments.PaymentProcess(DateTime.Now, value);
}
else
{
    Console.WriteLine("Forma de pagamento inválida!");
}

