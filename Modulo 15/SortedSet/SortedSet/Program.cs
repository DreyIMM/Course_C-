using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando com elementos dentro da Collection (coleções)
            SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,6,8,10};

            SortedSet<int> b = new SortedSet<int>() { 5, 7, 8, 9, 10};


               //union with conjunt
               //conjunto c, possuí todos os elementos do conjunto a 
               //o SorteSet sempre amostra os elementos ordenados
               SortedSet<int> c = new SortedSet<int>(a)
                //inclui em c, os elementos de B (caso tenho o mesmo, não duplica)
                c.UnionWith(b);
                PrintCollection(c);

                //Intersection
                SortedSet<int> d = new SortedSet<int>(a);
                d.IntersectWith(b);
                PrintCollection(d);

                //Difference

                SortedSet<int> e = new SortedSet<int>(a);
                e.ExceptWith(b);
                PrintCollection(e);


        }


        //Função genecrs (IEnumerable -> interface implementa por todas Collection
        //Nesse caso o ForEach funciona para collection
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            //forEach do tipo T
            foreach(T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }

            string  a = Console.ReadLine();
        }
    }
}
