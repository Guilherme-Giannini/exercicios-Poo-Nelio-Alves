using System;
using System.Globalization;

namespace Exercicio01;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine());

        ContaBancaria conta;
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre um valor para depósito: ");
        double quantiaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantiaDeposito);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre um valor para saque: ");
        double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantiaSaque);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);
    }
}





