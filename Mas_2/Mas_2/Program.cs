using System;

namespace Mas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите X:");
            X = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[1000];
            for (int i = 0; i < N; i++)
            {
                A[i] = X;
                X++;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
