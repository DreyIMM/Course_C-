using System;
using System.IO;
using System.Collections.Generic;
using Utilizando_Interface_IComparable.Entities;
namespace Utilizando_Interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\in.txt";

            try
            {
                //Crio um objeto StreamReader e faço a leitura do path
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employees> list = new List<Employees>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employees(sr.ReadLine()));   
                    }
                    //Ordenar a lista em ordem alfabetica
                    list.Sort();
                    foreach (Employees emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurrred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
