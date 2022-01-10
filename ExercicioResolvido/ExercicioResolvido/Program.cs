using System;
using System.Globalization;
using ExercicioResolvido.Entites.Enums;
using ExercicioResolvido.Entites;
namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do departamento :");
            string nameDepartment = Console.ReadLine();

            Console.WriteLine("Insira os dados do trabalhador :");
            Console.WriteLine();

            Console.Write("Insira o nome");
            string name = Console.ReadLine();

            Console.Write("Nivel: (Junior/Pleno/Senior) :");
            WorkerLevel livel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base de salário");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Department dept = new Department(nameDepartment);
            Worker worker = new Worker(name, livel, salary, dept);

            Console.WriteLine();

            Console.Write("Deseja cadastrar quantos contratos ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Insira#{i} dados do contrato ");
                Console.Write("Date (DD/MM/YYYY ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração por hora");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }
            Console.WriteLine();
            Console.Write("Entre com o mês e o ano para calcular os ganhos (mm/yyyy)");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Nome " +worker.Name);
            Console.WriteLine("Departamento " +worker.Department.Name);
            Console.WriteLine("Ganhos em " + monthAndYear + ": " + worker.income(year, month).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
