using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.WriteLine("Digite a quantidade de numeros");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                string x = Console.ReadLine();

                printService.addValue(x);
            }

            // Problema ao utilizar o Objetc (Infere ao Type Safety
            int a = (int)printService.Frist();
            int b = a + 2;
            Console.WriteLine(b);


            printService.Print();
            Console.WriteLine("Frist :" + printService.Frist());

            qtd = int.Parse(Console.ReadLine());
        }
    }
}
