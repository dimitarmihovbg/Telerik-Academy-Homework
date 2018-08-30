using System;

namespace ArraysN
{
    class ArraysN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N <= 20)
            {
                int[] ArrayN = new int[N];
                for (int i = 0; i < N; i++)
                {
                    ArrayN[i] = i * 5;
                }
                foreach (int value in ArrayN)
                {
                    Console.WriteLine(value);
                }
            }            
        }
    }
}
