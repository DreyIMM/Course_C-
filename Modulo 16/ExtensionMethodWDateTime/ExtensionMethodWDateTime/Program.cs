using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodWDateTime.Extensions;
namespace ExtensionMethodWDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2022, 03, 09 , 8, 10, 45);
            
            Console.WriteLine(dt.ElapsedTime());


        }
    }
}
