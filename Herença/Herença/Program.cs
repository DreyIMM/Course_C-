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
            Account acc = new Account(1001, "Andrey", 0.0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.0, 500);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Carlos", 0.4, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(200);

            //ERRO INTERESSANTE PARA O UPCASTIN

            //(ERRO) acc2.Loan(200);

            //(ERRO) PQ ACC3 NÃO TEM RELAÇÃO COM BUSSINES-ACCOUNT BussinesAccount acc5 = (BussinesAccount)acc3;
            if (acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3;
                BussinesAccount acc5 = acc3 as BussinesAccount;
                // as é outra forma de fazer o DownCasting
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            else
            {
                Console.WriteLine("acc3 não é uma instância de BussinesAccount ");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalacen();
                Console.WriteLine("Upadte ! ! !");
            }



        }
    }
}
