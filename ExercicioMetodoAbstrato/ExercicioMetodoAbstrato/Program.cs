using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioMetodoAbstrato.Entities;
using ExercicioMetodoAbstrato.Entities.Enums;
namespace ExercicioMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Digite o numero de figuras");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.Write($"Figura #{i} Dados:");
                Console.Write("Retangulo ou circulo (R/C) ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preta/Azul/Vermelha) ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if(op == 'R')
                {
                    Console.Write("Altura ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Largura ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else{

                    Console.Write("Raío ");
                    double raios = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(raios, color));
                
                }

               
            }
            Console.WriteLine("Área das figuras");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
