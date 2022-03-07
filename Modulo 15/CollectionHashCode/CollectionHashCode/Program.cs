using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHashCode.Entities;
namespace CollectionHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebokk", 1200));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            //esse obj é diferente do ("Notebokk", 1200) primeiro (A)
            Product prod = new Product("Notebokk", 1200);

            //estou testando se no meu conjunto a contém prod
            //Res: False -> embora os dados sejam iguais, o metodo contains diz que não está contido
            //Logo foi comparado as referências de memoria

            //Como inclui o metodo Equals e GetHascode na Classe Product, o resultado será verdadeiro, já que ocorre uma comparação
            //de contéudo e não de referência
            Console.WriteLine(a.Contains(prod));


            Point p = new Point(5, 10);


            //Rest -> Verdadeiro
            //Motivo: Quando é struc, ocorre uma comparação de conteúdo e não por referência
            Console.WriteLine(b.Contains(p));



        }
    }
}
