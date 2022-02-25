using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerecisRestrision.Service;
using GenerecisRestrision.Entites;
using System.Globalization;
namespace GenerecisRestrision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Product> list = new List<Product>();

            Console.Write("Repeticao ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vs = Console.ReadLine().Split(',');
                string name = vs[0];
                double price = double.Parse(vs[1], CultureInfo.InvariantCulture) ;

                list.Add(new Product(name,price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max ");
            Console.WriteLine(max);




        }
    }
}
