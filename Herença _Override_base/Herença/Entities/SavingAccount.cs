using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herença.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }


        public SavingAccount() { }

        public SavingAccount(int number, string holder, double balance, double interesRate)
        {
            InterestRate = interesRate;
        }


    }
}
