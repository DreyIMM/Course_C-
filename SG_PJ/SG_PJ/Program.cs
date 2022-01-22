using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SG_PJ.Entities;
namespace SG_PJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            list.Add(new Individual("Andrey",50000,2000));

            Console.WriteLine("Valores");
            foreach(People l in list)
            {
                Console.WriteLine("Andrey " +l.CalcTax());
            }

        }
    }
}
