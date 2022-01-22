using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SG_PJ.Entities;
namespace SG_PJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            Console.Write("Numeros de empresas ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.Write("Individual ou Companhia ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome ");
                string name = Console.ReadLine();

                Console.Write("Renda anual ");
                double incomeAnual = double.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Gasto com saúde ");
                    double healthExpen = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, incomeAnual, healthExpen));
                }
                else
                {
                    Console.Write("Total de funcionarios ");
                    int qtdFunc = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, incomeAnual, qtdFunc));
;
                }

            }

            Console.WriteLine("Imposto Individual ");
            foreach(People p in list)
            {
                Console.Write(p.Name + " $");
                Console.WriteLine(p.CalcTax());
            }


            
            double sum=0;
            foreach (People p in list)
            {
                sum =sum + p.CalcTax(); 
            }
            Console.Write("Total de imposto arrecado pelo governo: " +sum);

        }
    }
}
