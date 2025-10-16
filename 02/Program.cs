/* 2.Encapsulamento – Conta Bancária
Objetivo: controlar o acesso a dados sensíveis e validar operações.
Descrição:
Crie uma classe ContaBancaria com:
Propriedades privadas: Saldo, Titular.
Métodos públicos: Depositar(decimal valor) e Sacar(decimal valor).
O método Sacar deve impedir saques maiores que o saldo disponível.
Implemente getters e setters de forma controlada (por exemplo, permitir ler o saldo, mas não alterá-lo diretamente). */


using _02;
using System.Reflection;

BankAccount account = new BankAccount();
double money;
string option;


Console.WriteLine("--------- Bem-vindo ao seu banco ---------");
Console.WriteLine("Digite seu nome para acesso a conta");
account.SetHolder(Console.ReadLine()!);

do
{
    Console.WriteLine("\n");
    Console.WriteLine("Informe qual operação gostaria de realizar");
    Console.WriteLine("\t1 - Depositar\n\t2 - Sacar\n\t3 - Ver Saldo\n\t4 - Finalizar");
    option = (Console.ReadLine()!);

    Console.Clear();


    Console.WriteLine("\n...Processando solicitação....\n");


    switch (option)
    {
        case "1":
            Console.WriteLine("Qual valor gostaria de depositar?");
            money = double.Parse(Console.ReadLine()!);
            account.BankDeposity(money);
            break;
        case "2":
            Console.WriteLine("Qual valor gostaria de sacar?");
            money = double.Parse(Console.ReadLine()!);
            account.Withdrawals(money);
            break;
        case "3":
            Console.WriteLine(account.GetBalance());
            break;
        case "4":
            Console.WriteLine($"Obrigado, tenha um ótimo dia!");           
            break;
        default:
            Console.WriteLine("ERRO! Operação não encontrada");
            Console.WriteLine("\t1 - Depositar\n\t2 - Sacar\n\t3 - Ver Saldo\n\t4 - Finalizar");
            Console.Clear();
            break;
    }
} while (option != "4");

