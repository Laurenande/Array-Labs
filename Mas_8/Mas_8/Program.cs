using System;

namespace Mas_8
{
    class Program
    {
        static int randInt(int a, int b)
        {
            Random rnd = new Random();
            return a + rnd.Next() % (b - a + 1);
        }

        static void Main(string[] args)
        {

            int N, A, B;
            int countOdd = 0;
            int countEven = 0;
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Arr[i] = randInt(A, B);
                if (Arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.WriteLine("\n" + "Нечетных: " + countOdd);
            Console.WriteLine("Четных: " + countEven);

        }
    }
}
