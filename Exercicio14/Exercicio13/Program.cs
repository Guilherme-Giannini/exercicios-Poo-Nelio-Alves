﻿using Exercicio13.Entities;

namespace Exercicio13;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

        // UPCASTING
        Account acc1 = bacc;
        Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        // DOWNCASTING
        BussinessAccount acc4 = (BussinessAccount)acc2;
        acc4.Loan(100.0);

        //BussinessAccount acc5 = (BussinessAccount)acc3; -> Erro de execusão, pois acc3 é do tipo savingsAccount
        if (acc3 is BussinessAccount)
        {
            //BussinessAccount acc5 = (BussinessAccount)acc3;
            BussinessAccount acc5 = acc3 as BussinessAccount;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }
        else if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }
    }
}