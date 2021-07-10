using System;

namespace Ekz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y,A;
            int count = 0;
            Console.WriteLine("Введите длину массивов:");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите A:");
            A = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[Y];
            int[] Arr2 = new int[Y];

            for(int i = 0;i < Y;i++)
            {
                Console.WriteLine("Y[" + i + "]:");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Y; i++)
            {
                Console.WriteLine("X[" + i + "]:");
                Arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 0; i < Y; i++)
            {
                int B = 0;
                B = Arr[i] - Arr2[i];
                Console.WriteLine( "B = " + B);
                if (B < A)
                {
                    count++;
                }     
            }
            Console.WriteLine("A = " + A);
            Console.WriteLine("Колличество замен: " + count);
        }
    }
}
