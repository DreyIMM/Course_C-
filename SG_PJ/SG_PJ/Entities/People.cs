using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_PJ.Entities
{
    class People
    {
        public string Name { get; set; }
        public double  AnnualIncome { get; set; }

        public People() { }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public double CalcTax()
        {
            return 0;
        }


    }
}
