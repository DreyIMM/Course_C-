using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action_Exemplo.Entities;

namespace Action_Exemplo
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

            //Como fazer para aumentar o preço de cada produto em 10%
            //ForEach seria uma solução


            //Aplicando para todos
            list.ForEach(UpdatePrice);

            foreach(Product p in list)
            {
                Console.WriteLine("sem action" +p);
            }
            Console.WriteLine();
            //Agora com action

            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (Product p in list)
            {
                Console.WriteLine("com action" + p);
            }

            //Outra opção seria colocando uma função Lambda direta no ForEach

            list.ForEach(p => { p.Price += p.Price * 0.1;});

            foreach (Product p in list)
            {
                Console.WriteLine("Com lambda" + p);
            }

        }


        //Função auxiliar - Que atualiza o preço de um produto
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }
}
