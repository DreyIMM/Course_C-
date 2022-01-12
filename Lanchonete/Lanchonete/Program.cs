using System;
using System.Collections.Generic;
using System.Globalization;
using Lanchonete.Entities;
using Lanchonete.Entities.Enums;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- -Insira dados do cliente - - ");
            
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de aniversário: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
                       
            Console.Write("Insira o status do produto: ");
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Console.Write("Quantos itens para o pedido: ");
            int totalItens = int.Parse(Console.ReadLine());

            

            for(int i=1; i <= totalItens; i++)
            {
                Console.WriteLine($"Pedido{i} - Insira os dados");
                Console.Write("Nome do produto: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtdProduct = int.Parse(Console.ReadLine());

            }






        }
    }
}
