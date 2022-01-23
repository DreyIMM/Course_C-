using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;
using Bank.Entities.Exceptions;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Insira os dados da conta");
                Console.Write("Numero ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Cliente ");
                string name = Console.ReadLine();
                Console.Write("Valor inícial ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque ");
                double withdrawL = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Valor para saque ");
                double amountWith = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account a1 = new Account(num, name, balance, withdrawL);
                a1.Withdraw(amountWith);
                Console.WriteLine(a1);

            }catch(DomainExceptions e)
            {
                Console.WriteLine("Error: " +e.Message);
            }




            }
    }
}
