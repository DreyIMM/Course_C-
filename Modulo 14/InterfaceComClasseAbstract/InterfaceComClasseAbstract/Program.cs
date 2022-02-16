using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceComClasseAbstract.Models.Entities;
using InterfaceComClasseAbstract.Models.Enums;
namespace InterfaceComClasseAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Color = Color.Black,
                Radius = 2.0
            };


            IShape s2 = new Rectangle()
            {
                Width =2.5,
                Height = 4.2,
                
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
