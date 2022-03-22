using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using ExercicioOfProduct.Entities;
namespace ExercicioOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Console.Write("Numero de produtos ");
            int p = int.Parse(Console.ReadLine());

            for(int i =1; i<=p; i++)
            {
                Console.Write("Comum, usado, importado (c/u/i) ");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Nome ");
                string name = Console.ReadLine();

                Console.Write("Preço ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (option)
                {
                    case 'c':
                        list.Add(new Product(name, preco));
                        break;
                    case 'u':
                        Console.Write("Fabricação: ");
                        DateTime dt = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, preco, dt));
                        break;
                    case 'i':
                        Console.Write("Taxa da Alfandega");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, preco, fee));
                        break;
                    default:
                        Console.WriteLine("Objeto não criado");
                        break;
                }



            }

            Console.WriteLine();
            foreach (Product l in list)
            {               
                Console.WriteLine(l.PriceTag());
            }
            
        }
    }
}
