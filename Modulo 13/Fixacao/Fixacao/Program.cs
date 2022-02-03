using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourchPath = @"d:\myfolder\File.txt";

            try
            {

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
