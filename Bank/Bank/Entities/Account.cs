using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Exceptions;
using System.Globalization;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimiti { get; set; }
    
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimiti)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimiti = withdrawLimiti;
        }

        public void Deposit(double amount)
        {
            
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainExceptions("Valor do saque excede o limite ");
            }
            if(amount > WithdrawLimiti)
            {
                throw new DomainExceptions("Limite de saque não permitido");
            }
            Balance -= amount;
        }


        public override string ToString()
        {
            return "Atualização: " +Balance.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
