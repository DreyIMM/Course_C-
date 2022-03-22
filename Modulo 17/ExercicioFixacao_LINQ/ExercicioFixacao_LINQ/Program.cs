using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using ExercicioFixacao_LINQ.Entities;
namespace ExercicioFixacao_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"d:\in.txt";

            Console.Write("Insira o salário: ");
            double salary_avg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));

                }
            }

            var emails = list.Where(p => p.Salary > salary_avg).OrderBy(p => p.Name).Select(p => p.Email);

            Console.WriteLine();
            foreach(String emp in emails)
            {
                Console.WriteLine(emp);
            }

            var avg = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine();
            Console.WriteLine("Média " + avg.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
