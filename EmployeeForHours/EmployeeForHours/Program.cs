using System;
using System.Collections.Generic;
using EmployeeForHours.Entitites;
using System.Globalization;

namespace EmployeeForHours
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); 
            
            Console.Write("Quantidade de funcionarios ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i <= n; i++)
            {
                Console.Write($"Employee  #{i} data: ");
                Console.Write("Funcinário terceirizado (y/n)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                
            }

                Console.WriteLine() ;
                Console.Write("---- Payments ------");

                foreach(Employee em in list)
                {
                    Console.WriteLine(em.Name);
                    Console.Write("R$" +em.Payment().ToString("F2",CultureInfo.InvariantCulture));
                }

            

        }
    }
}
