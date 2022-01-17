using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herença.Entities
{
    class SavingsAccount :Account
    {

        public double IntersesaRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance,double intersesaRate)
            :base(number,holder,balance)
        {
            IntersesaRate = intersesaRate;
        }

        public void UpdateBalacen()
        {
            Balance += Balance * IntersesaRate;
        }

    }
}
