using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\in.txt";

            


            try
            {
                
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> CandidatoVoto = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        int value = int.Parse(line[1]);
                        string key = line[0];

                        Console.WriteLine(value);
                        if (CandidatoVoto.ContainsKey(key))
                        {
                            // faz sentido mais ainda está confuso
                             CandidatoVoto[key] = CandidatoVoto[key] + value;
                             Console.WriteLine(CandidatoVoto[key]);
                        }
                        else
                        {
                            CandidatoVoto[key] = value;
                        }                                           
                       

                    }




                    
                    foreach(KeyValuePair<string,int> people in CandidatoVoto)
                    {
                        Console.WriteLine(people.Key + ": " + people.Value);
                    }


                }


            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string a = Console.ReadLine();
        }
    }
}
