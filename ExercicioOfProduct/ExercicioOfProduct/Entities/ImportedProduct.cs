﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExercicioOfProduct.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
           
        }
        public ImportedProduct(string name, double price, double customsFee) 
            :base(name,price)
        {
            CustomsFee = customsFee;
        }


        public double TotalPrice()
        {
            return CustomsFee + Price;
        }


        public override string PriceTag()
        {
            return Name + " R$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + "( Customs fee $ " + CustomsFee + ")";
        }
    }
}
