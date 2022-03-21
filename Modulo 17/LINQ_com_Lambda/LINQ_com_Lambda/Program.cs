using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_com_Lambda.Entities;
namespace LINQ_com_Lambda
{
    internal class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            Category c1 = new Category() { Id= 1, Name= "Tools", Tier=2};
            Category c2 = new Category() { Id = 2, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {

                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }

            };
            //Exprssion with Lambda for Filter in DataSource (LINQ)
            var r1 = products
                .Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and Price < 900: " , r1);



            var r2 = products
                .Where(p => p.Category.Name== "Tools")
                .Select(p => p.Name);
            Print("Names of products from tools", r2);

            //Nesse caso, para pegarmos só três atributos, declaramos um objeto anonimo (p=> new ...... 
            //OBS CategoryName é um apelido para não gerar erro no Category.Name
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names stared with C", r3);

            //Selecione categorio ==1 e ordena por preço e depois por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name",r4);

            //Muito utilizado para paginação
            //Pula dois primeiro e pega 4 elementos
            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price then by name: SKIP 2 TAKE 4", r5);

            //Firts não funcionando no LINQ


            //Só utiliza-se o singleOrDefautl quando quer que retorne 1 ou nenhum elemento, caso seja >1, da erro
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1  " + r8);

            


        }
    }
}
