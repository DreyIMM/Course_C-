using System;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            Console.Write("Linhas ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Coluna ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for(int i = 0; i < M; i++) {

                Console.WriteLine("Valores da coluna");
                string[] values = Console.ReadLine().Split(' ');
               

                for(int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Numero desejado");
            int option = int.Parse(Console.ReadLine());

            int l, c;
            for (int i = 0; i < M; i++) {
                              
                for (int j = 0; j < N; j++) {
                   if( mat[i, j] == option) {
                       
                        Console.WriteLine("Position " + i +","+j);
                        if (j > 0) {
                            Console.WriteLine("Left " + mat[i, j - 1]); 
                        }
                        if(j < N - 1) {
                            Console.WriteLine("Right " + mat[i, j + 1]);
                        }
                        if(i > 0) {
                            Console.WriteLine("Up " + mat[1 - i, j]);
                        }
                        if(i < M - 1) {
                            Console.WriteLine("Down " + mat[1 + i, j]);
                        }
                        
                        
                    } 
                }
            }



        }
    }
}
