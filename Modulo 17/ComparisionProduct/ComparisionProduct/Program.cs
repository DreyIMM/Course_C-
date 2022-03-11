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
            //Dessa forma, funciona, mas viola o principio solid ocp
            list.Sort();

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }





        }
    }
}
