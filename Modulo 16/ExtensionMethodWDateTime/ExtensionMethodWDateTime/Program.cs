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
            // 8:30 da manhã
            DateTime dt = new DateTime(2022, 3, 10 , 8, 30, 45);
 
            Console.WriteLine(dt.ElapsedTime());


        }
    }
}
