using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos um conjunto VAZIO
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            //Deve ser feito pelo forEach, já que o conjunto não possui posição, não tem como fazer por FOR

            foreach(string s in set)
            {
                Console.WriteLine(s);
            }




        }
    }
}
