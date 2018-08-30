using System;
using System.Linq;

namespace max_sum_sequence_2
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] arrayN = new int[N];
            for (int m = 0; m < N; m++)
            {
                arrayN[m] = int.Parse(Console.ReadLine());
            }
            int[] arrayK = new int[K];
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < K; k++)
                {
                    if (arrayN[i] > arrayK[k])
                    {
                        arrayK[k] = arrayN[i];
                    }
                }
            }
            int sumResult = 0;
            for (int s = 0; s <K; s++)
            {
                sumResult += arrayK[s];
            }
            Console.WriteLine(sumResult);
        }
    }
}
