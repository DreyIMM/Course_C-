using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path = @"d:\myfolder";

            try
            {
                //O segundo argumento diz: qualquer nome de arquivo / qualquer extensão

                // var  folder = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories); (Alternativa)

                IEnumerable<string> folder = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);
                //Isso permite listar todas as sub-pastas do path

                Console.WriteLine("FOLDERS");
                foreach (string it in folder)
                {
                    Console.WriteLine(it);    
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(Path, "*.txt", SearchOption.AllDirectories);
                Console.WriteLine("FILE's: ");
                foreach (string it in files)
                {
                    Console.WriteLine(it);
                }


                //CRIANDO UMA PASTA
                Directory.CreateDirectory(Path + "\\newfolder");


            }
            catch (Exception ex)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
