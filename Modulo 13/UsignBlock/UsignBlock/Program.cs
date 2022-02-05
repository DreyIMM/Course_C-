using System;
using System.IO;

namespace UsignBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\File.txt";


            try {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
