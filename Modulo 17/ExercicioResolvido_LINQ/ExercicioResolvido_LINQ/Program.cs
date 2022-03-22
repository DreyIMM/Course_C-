using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvido_LINQ.Entities;
using System.IO;
using System.Globalization;
namespace ExercicioResolvido_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Console.Write("Digite o caminho do arquivo");
           //string path = Console.ReadLine();

            string path = @"d:\in.txt";

            List<Product> prd = new List<Product>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);

                        prd.Add(new Product(name, price));
                        
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Message: " +ex);
            }
           

            //média dos produtos
            var avg = prd.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Média = " +avg.ToString("F2", CultureInfo.InvariantCulture));
           
            //Nomes dos produtos que estão abaixdo da media E em ordem decrescente

            var names = prd.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            Console.WriteLine("Produtos");

            foreach(String name in names)
            {
                Console.WriteLine(name);
            }





        }
    }
}
