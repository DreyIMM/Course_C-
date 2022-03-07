using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExercicioConjunto.Entities;

namespace ExercicioConjunto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> records = new HashSet<LogRecord>();

            string path = @"d:\in.txt";
            //Lendo um arquivo, e seperando linha por linha
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {   
                        //envia uma linha para variavel line
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];

                        DateTime instant = DateTime.Parse(line[1]);
                        //não entra username repetido
                        records.Add(new LogRecord { Username = name, Instant = instant });

                    }
                    Console.WriteLine("Total user: " +records.Count);
                }

            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);   
            }



        }
    }
}
