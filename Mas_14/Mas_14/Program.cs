using System;

namespace Mas_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int min = -1;
            int max = -1;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + i + "]: ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if ((Arr[i] > 0) && (Arr[i] % 2 == 0))
                {
                    if (Arr[i] > max)
                    {
                        max = Arr[i];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                if ((Arr[i] > 0) && (Arr[i] % 2 == 0))
                {
                    if (min < 0)
                    {
                        min = Arr[i];
                    }
                    else
                    {
                        if (Arr[i] < min)
                        {
                            min = Arr[i];
                        }
                    }
                }
            }
            Console.WriteLine("Максимальное: " + max + '\n' + "Минимальное: " + min);
        }
    }
}
