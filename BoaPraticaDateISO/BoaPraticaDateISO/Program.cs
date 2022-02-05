using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoaPraticaDateISO {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15, 14, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 14, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 14, 5, 58);

            DateTime f = DateTime.Now;

          

            Console.WriteLine();
            Console.WriteLine("d1) " + f);
            Console.WriteLine("d1 kind: " + f.Kind);
            Console.WriteLine("d1 to local: " + f.ToLocalTime());
            Console.WriteLine("d1 to utc: " + f.ToUniversalTime());
            Console.WriteLine();
        }
    }
}
