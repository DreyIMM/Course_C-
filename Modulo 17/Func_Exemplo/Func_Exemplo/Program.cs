using System;
using System.Collections.Generic;
using System.Linq;

using Func_Exemplo.Entities;
namespace Func_Exemplo
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


            //A partir dessa lista, gerar uma nova em caixa alta, com os nomes


            //Usaremos a função select, que pega a colecction e transforma em outra (Pertecen ao System.Linq)
            //Tivemos que colocar o .ToList, porque o NameUpper se tornar uma IEnumerable(mais generica)
            List<string> result = list.Select(NameUpper).ToList();

           foreach(string s in result)
            {
                Console.WriteLine(s);
            }
           


        }


        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();  
        }
    }
}
