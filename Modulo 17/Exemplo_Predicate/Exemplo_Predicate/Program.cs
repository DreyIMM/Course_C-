using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_Predicate.Entities;

namespace Exemplo_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();


            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //remover da lista que o produto seja >= 100
            //Uma alternativa com função Lambda
            // -> list.RemoveAll(p => p.Price >= 100.0);
            // Agora alternativa utiliza o Predicate

            list.RemoveAll(ProductTeste);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        public static bool ProductTeste(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
