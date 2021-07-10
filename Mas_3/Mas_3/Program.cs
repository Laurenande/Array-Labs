using System;

namespace Mas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[1000];
            for (int i = 1; i <= N; i++)
            {
                A[i - 1] = i * i;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
