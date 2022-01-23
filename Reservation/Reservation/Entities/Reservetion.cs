using System;


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
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "   Erro, data de entrada deve ser maior que saída  - Dada futura  " ;
            }
            if (checkOut <= checkIn)
            {
                 return "Erro, data de entrada deve ser maior que saída" ;
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
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
