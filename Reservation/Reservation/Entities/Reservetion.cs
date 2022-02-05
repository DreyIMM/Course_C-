using System;
using Reservation.Entities.Exceptions;

namespace Reservation.Entities
{
    class Reservetion
    {
        public int RoomNumber{ get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservetion() { }

        public Reservetion(int roomNumber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut <= checkIn)
            {
                throw new DomainException("Constructo -  data de entrada deve ser maior que saída");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("   Erro, data de entrada deve ser maior que saída  - Dada futura ") ;
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro, data de entrada deve ser maior que saída") ;
            }
            //O throw corta o método, ou seja, não executa mais nada, igual o return
            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }



        public override string ToString()
        {
            return "Quarto "
                + RoomNumber
                + ", chek-in: "
                + CheckIn.ToString("dd/MM/yyyy    ")
                + ", check-out"
                + CheckOut.ToString("dd/MM/yyyy   ")
                + Duration()
                + " noites";
        }
    }
}
