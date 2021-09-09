using System;

namespace p09_vectoraleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=15;
            int[] A = new int [TAM];
            int[] B = new int [TAM];
            int[] C = new int [TAM];

            Random rnd = new Random();

            for(int i=0; i<A.Length; i++) {
                A[i] = rnd.Next(1,100);
                B[i] = rnd.Next(1,100);
                C[i] = A[i] + B[i];
            }
            Console.WriteLine("\nElemento de A: "); imprime(A);
            Console.WriteLine("\nElemento de B: "); imprime(B);
            Console.WriteLine("\nElemento de C: "); imprime(C);
        }
        static void imprime(int[] v) {
            for(int i=0; i<v.Length; i++) {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
    }
}
