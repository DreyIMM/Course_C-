using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"d:\File.txt";
            

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(tagetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                             


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }




        }
    }
}
