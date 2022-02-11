using System;
using ProjectOfServiceNoInterface.Entities;
using System.Globalization;
using ProjectOfServiceNoInterface.Services;

namespace ProjectOfServiceNoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Entrada (DD/MM/yyyy hh:mm ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entrada (DD/MM/yyyy hh:mm ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            

            Console.Write("Preço por hora ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Preço por dia ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxServices());

            rentalService.ProcessInvoice(carRental);
            
            Console.WriteLine("Fatura");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
