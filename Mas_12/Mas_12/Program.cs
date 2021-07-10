using System;

namespace Mas_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,X;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите X:");
            X = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + (i + 1) + "]: ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (Arr[i] == X)
                {
                    Console.Write((i + 1) + " ");

                }
            }

        }
    }
}
