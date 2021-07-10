using System;

namespace Mas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[100];
            for (int i = 0; i < N; i++)
            {
                A[i] = i + 1;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
