﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }





        }
    }
}
