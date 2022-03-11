using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparisionProduct.Entities;
namespace ComparisionProduct
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 3.000));
            list.Add(new Product("Carro", 30.000));

            //Sort para ordenar (Só funciona se o tipo da lista implementea a interface ICompareble
            
            //Delegate -> Referencia para função com Type Safe
            list.Sort(CompareProdut);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProdut(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

    }
}
