using System;

namespace Mas_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int max;
            int count = 0;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + i + "]: ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = Arr[0];

            for (int i = 0; i < N; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (Arr[i] == max)
                {
                    count++;
                }
            }
            Console.WriteLine("Максимальное: " + max + '\n' + "Количество равных максимальному: " + count);


        }
    }
}
