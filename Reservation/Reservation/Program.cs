using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.Entities;
using Reservation.Entities.Exceptions;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do quarto ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in data: (dd/MM/yyyy) ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data: (dd/MM/yyyy) ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservetion reservertion = new Reservetion(number, checkIn, checkOut);
                Console.WriteLine(reservertion);

                Console.WriteLine();

                Console.WriteLine("Insira dados para atualizar a reserva");
                Console.Write("Check-in data: (dd/MM/yyyy) ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data: (dd/MM/yyyy) ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservertion.UpdateDates(checkIn, checkOut);

                Console.Write("Reservation: " + reservertion);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error na reservação: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro de formatação: " +e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado louco: " +e.Message);
            }


        }



    }
}

