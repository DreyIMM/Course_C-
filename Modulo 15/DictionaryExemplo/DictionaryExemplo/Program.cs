using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //brincadeira com o cookes web
            //Dictionary não aceita repitição, o que ocorre é uma substituição do valor.
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Andrey";
            cookies["password"] = "github";
            cookies["Nivel"] = "Junior";
            cookies["Locale"] = "Brazil";


            
            
            Console.WriteLine("size" +cookies.Count);

            Console.WriteLine("All cookies");

            foreach(KeyValuePair<string,string> cookie in cookies)
            {
                Console.WriteLine(cookie.Key + " : " + cookie.Value);
            }

        }
    }
}
