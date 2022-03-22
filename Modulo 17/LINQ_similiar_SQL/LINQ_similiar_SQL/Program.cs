using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using LINQ_similiar_SQL.Entities;
namespace LINQ_similiar_SQL
{
    internal class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
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

            var r1 = from p in products 
                     where p.Category.Tier == 1 && p.Price < 900.00 
                     select p;
            Print("Tier 1 and Price < 900: ", r1);



            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;
                    
            Print("Names of products from tools", r2);

            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };


            Print("Names stared with C", r3);





            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;


            Print("Tier 1 order by price then by name", r4);

            //Muito utilizado para paginação
            //Pula dois primeiro e pega 4 elementos
            var r5 =(from p in r4 select p).Skip(2).Take(4);
            Print("Tier 1 order by price then by name: SKIP 2 TAKE 4", r5);

            //Firts não funcionando no LINQ


            //Só utiliza-se o singleOrDefautl quando quer que retorne 1 ou nenhum elemento, caso seja >1, da erro
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1  " + r8);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price " + r11);

            //Filtrar os produtos da categoria 1 e a soma dos preços
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            //Filtrar os produtos da categoria 1 e a média dos preços
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 média prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("média vazia, evitando erro: Category 5 média prices: " + r14);

            //Operação Agregate (Map.reduce)
            //Monta uma operação agregada reduziada
            //caso o id seja vazio, terá que tratar a execption, colocando depois do Aggregate o valor para substituir caso o Where seja nulo

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = from p in products
                      group p by p.Category;
            Console.WriteLine();
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " +group.Key.Name+ " :");
                foreach(Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();

            }
           


        }
    }
}
