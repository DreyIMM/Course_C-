using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.Entities
namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Numero do quarto ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in data: (dd/MM/yyyy) ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out data: (dd/MM/yyyy) ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservetion reservertion = new Reservetion(number, checkIn, checkOut);


        }
    }
}
