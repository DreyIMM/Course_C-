using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_PJ.Entities
{
    class Company : People
    {
        public int ValueEmployee { get; set; }

        public Company() { }

        public Company(string name, double annualIncome,int vEmployee) : base(name, annualIncome)
        {
            ValueEmployee = vEmployee;
        }


        public override double CalcTax()
        {
           double valueTax=0;
           if(ValueEmployee > 10)
            {

                 valueTax = AnnualIncome * 0.14;

            }
            else
            {
                valueTax = AnnualIncome * 0.16;
            }

            return valueTax;
           

        }

    }
}
