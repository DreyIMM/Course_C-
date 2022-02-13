using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicio.Services
{
    internal class PaypalService: IOnlinePaymentService
    {
        public double PaymentFree(double amount)
        {
            return amount;  
          
        }

        public double Interest(double amount, int months)
        {
            double total;
            total = amount + (0.1 * months);
            total = total + 0.02;

            return total;
        }

    }
}
