using System;

namespace Mas_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;
            int count = 0;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите X:");
            X = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + i + "]:");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (Arr[i] == X)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество X в массиве: " + count);

        }
    }
}
