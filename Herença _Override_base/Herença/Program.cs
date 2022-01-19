using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herença.Entities;

namespace Herença
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Andrey", 500.0);
            Account acc2 = new SavingsAccount(1002,"Ana",500,0.01);

            acc1.Whitdram(10.0);
            acc2.Whitdram(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
