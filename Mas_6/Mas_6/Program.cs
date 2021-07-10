using System;

namespace Mas_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            int temp = N;

            int[] A = new int[1000];
            for (int i = 1; i <= N; i++)
            {
                A[i - 1] =Convert.ToInt32(Math.Pow(2, temp));
                temp--;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
