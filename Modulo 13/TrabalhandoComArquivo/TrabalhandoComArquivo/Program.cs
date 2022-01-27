using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhandoComArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourchPath = @"d:\File.txt";
            string targetPath = @"d:\File1.txt";

            //o @ foi utlizado para evitar \\ 

            try
            {
                FileInfo f1 = new FileInfo(sourchPath);
                f1.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourchPath);
                
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
               
            
            }catch(IOException e){
                Console.WriteLine("An error occurrd");
                Console.WriteLine(e.Message);
            }
        
        
        
        
        
        }
    }
}
