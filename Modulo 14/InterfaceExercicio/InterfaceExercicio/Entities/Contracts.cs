﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercicio.Entities
{
    internal class Contracts
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set;}
        public Installment Installment { get; set; }

        public Contracts(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
           
        }
             

    }
}
    