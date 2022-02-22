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
            PrintService<string> printService = new PrintService<string>();

            Console.WriteLine("Digite a quantidade de nomes(String) ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                string x = Console.ReadLine();

                printService.addValue(x);
            }
            printService.Print();

            //Iniciando com outro type


            PrintService<int> printServiceInt = new PrintService<int>();
            Console.WriteLine("Digite a quantidade de numeros");
             int qtdN = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < qtdN; i++)
            {
                int x = int.Parse(Console.ReadLine());

                printServiceInt.addValue(x);
            }
                        

            printServiceInt.Print();
            Console.WriteLine("Frist :" + printServiceInt.Frist());
        }
    }
}
