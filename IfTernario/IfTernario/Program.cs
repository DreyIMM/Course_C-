using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IfTernario {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());


            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
