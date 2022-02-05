using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_PJ.Entities
{
    class Individual : People
    {
        public double SpentCare { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome,double spentCare) : base(name, annualIncome)
        {
            SpentCare = spentCare;
        }



        public override double CalcTax()
        {
            double valueTax=0;
            
            if(AnnualIncome < 20000)
            {
                
               valueTax = AnnualIncome * 0.15 ;

            }
            else
            {

                valueTax = AnnualIncome * 0.25 ;
            }

            if (SpentCare > 0)
            {
                valueTax = valueTax - (SpentCare/2);
            }


            return valueTax;

        }
    }
}
