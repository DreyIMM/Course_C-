using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.Entities;
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




            if (checkOut >= checkIn)
            {
                Reservetion reservertion = new Reservetion(number, checkIn, checkOut);
                Console.WriteLine(reservertion);

                Console.WriteLine();

                Console.WriteLine("Insira dados para atualizar a reserva");
                Console.Write("Check-in data: (dd/MM/yyyy) ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data: (dd/MM/yyyy) ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservertion.UpdateDates(checkIn, checkOut);

                if (error != null)
                {

                    Console.WriteLine("Error in reservartion " +error);
                }
                else
                {
                    Console.Write("Reservation: " +reservertion);

                }



            }
            else
            {
                Console.WriteLine("Erro, data de entrada deve ser maior que saída");
            }


        }
    }
}
