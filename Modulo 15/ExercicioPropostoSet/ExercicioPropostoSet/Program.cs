using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioPropostoSet.Entities;


namespace ExercicioPropostoSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<Students> stuts = new HashSet<Students>();

            Console.Write("Quantos estudantes no curso A ");
            int valueA = int.Parse(Console.ReadLine());
            for(int i = 0; i < valueA; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stuts.Add(new Students(value));
            }
            
            Console.Write("Quantos estudantes no curso B ");
            int valueB = int.Parse(Console.ReadLine());
            for (int i = 0; i < valueB; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stuts.Add(new Students(value));
            }

            Console.Write("Quantos estudantes no curso C ");
            int valueC = int.Parse(Console.ReadLine());
            for (int i = 0; i < valueC; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stuts.Add(new Students(value));
            }

            Console.WriteLine("Total de estudante para esse professor: " +stuts.Count);

        }
    }
}
