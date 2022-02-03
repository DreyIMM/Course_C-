using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStreamAndStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\File.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

               
               

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }



            }catch(IOException e)
            {
                Console.WriteLine("An error occurrd");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }

            //Como as variaveis StremRead e FileStrem são recursos do
            //Sistema operacional, é necessário finaliza-las. com Finally e .Close


        }
    }
}
