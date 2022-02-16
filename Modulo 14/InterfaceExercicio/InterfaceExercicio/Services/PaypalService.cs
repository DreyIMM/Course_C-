using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicio.Services
{
    internal class PaypalService: IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01; 

        
        public double Interest(double amount, int months)
        {
            return amount * months * MonthlyInterest;
        }

        public double PaymentFree(double amount)
        {
            return amount * FeePercentage ; 
          
        }

    }
}
