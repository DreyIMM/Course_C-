using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EqualsAndGetHasCode.Entities;
namespace EqualsAndGetHasCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clientes a = new Clientes { 
            Name = "Andrey",
            Email ="contato@thenProblem.com"
   
            };

            Clientes b = new Clientes
            {
                Name = "Andrey",
                Email = "about@usForever.com"

            };


            Console.WriteLine(a.Equals(b));
            //O equal está ligado ao email
            //o HasCode é ligado ao Name
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            //esse == está comparando referência do ponteiro de memoria do objeto
            Console.WriteLine(a == b);

        }
    }
}
