using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadeDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2023, 11, 10, 03, 30, 22, 256);

            Console.WriteLine(d);

            Console.WriteLine("1) Date " + d.Date);
            Console.WriteLine("2) Day: " +d.Day);
            Console.WriteLine("3) DayOfWeek " +d.DayOfWeek);
            Console.WriteLine("4) DayOfYear  " +d.DayOfYear);

            Console.WriteLine();

            Console.WriteLine(d.ToLongDateString());

            Console.WriteLine();
            Console.WriteLine();

            DateTime d1 = d.AddHours(2);

            Console.WriteLine(d);
            Console.WriteLine(d1);

            //Trabalhando com diferenças de datas

            DateTime a = new DateTime(2000, 10, 15);

            DateTime a1 = new DateTime(2000, 10, 18);

            TimeSpan resultado = a1.Subtract(a);

            Console.WriteLine("Diferença..: " +resultado);

        }
    }
}
