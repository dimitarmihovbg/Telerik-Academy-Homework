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
            if (N >= K && K >= 1 && N <= 1024)
            {
                int[] arrayN = new int[N];
                for (int m = 0; m < N; m++)
                {
                    arrayN[m] = int.Parse(Console.ReadLine());
                }
                int[] sortedCopy = arrayN.OrderByDescending(i => i).ToArray();
                int sum = 0;
                for (int i = 0; i < K; i++)
                {
                    sum += sortedCopy[i];
                }
                Console.WriteLine(sum);
            }
                    
        }
    }
}
