using ProjectOfServiceNoInterface.Entities;
using System;

namespace ProjectOfServiceNoInterface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        // não é (ERA) a melhor opção
        //private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();
       
        // Solução ideal:
        private ITaxService _taxService;
        

        public RentalService(double pricePerHour, double pricePerday, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerday;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.End.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
                //Math.Ceiling arredonda para cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
