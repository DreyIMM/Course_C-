using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerecisRestrision.Service;
namespace GenerecisRestrision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = new List<int>();

            Console.Write("Repeticao ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Valor: ");
                int value = int.Parse(Console.ReadLine());  
                list.Add(value);
            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(list);

            Console.WriteLine("Max ");
            Console.WriteLine(max);




        }
    }
}
