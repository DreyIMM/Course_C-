using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoMatriz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o tamanho da matriz: ");
            int tMatriz = int.Parse(Console.ReadLine());

            int[,] mat = new int[tMatriz, tMatriz];
           
                for (int i = 0; i< tMatriz; i++) {

                string[] values = Console.ReadLine().Split(' ');

                    
                    for(int j=0; j< tMatriz; j++) {
                        mat[i, j] = int.Parse(values[j]);
                    }

                }                                            

        }
    }
}
