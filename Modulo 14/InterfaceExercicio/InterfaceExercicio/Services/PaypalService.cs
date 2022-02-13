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

        public double interest(double amount, int months)
        {
            return amount;
        }

    }
}
