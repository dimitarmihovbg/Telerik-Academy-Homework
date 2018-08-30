using System;

namespace max_sum_sequence_2
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());            
            if (N >= 1 && N <= 1024)
            {
                int[] arrayN = new int[N];
                int sum = 0;
                for (int m = 0; m < N; m++)
                {
                    arrayN[m] = int.Parse(Console.ReadLine());
                    sum += arrayN[m];                    
                }    
                Console.WriteLine(sum);
            }

        }
    }
}
