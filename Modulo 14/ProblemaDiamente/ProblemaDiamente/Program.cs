using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemaDiamente.Devices;
namespace ProblemaDiamente
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Printer p = new Printer() { serialNumber = 1090};
            p.ProcessDoc("My letter");
            p.Print("My litter");

            Scanner s = new Scanner() { serialNumber = 2003 };
            s.ProcessDoc("My emaills");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { serialNumber = 3921 };
            c.ProcessDoc("My dissertion");
            c.Print("OK OK");
            Console.WriteLine(c.Scan());
        }
    }
}
