using System;

namespace Mas_5
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
            for (int i = N; i > 0; i--)
            {
                A[i - 1] = X;
                X++;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
