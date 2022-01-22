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


        public override double CalcTax()
        {
            throw new NotImplementedException();
        }

    }
}
