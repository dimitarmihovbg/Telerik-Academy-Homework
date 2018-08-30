using System;
using System.Collections.Generic;
using System.Linq;

namespace Duplicates
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N <= 1024)
            {
                int[] arrayN = new int[N];
                for (int m = 0; m < N; m++)
                {
                    arrayN[m] = int.Parse(Console.ReadLine());
                }
                var cnt = new Dictionary<int, int>();
                foreach (int value in arrayN)
                {
                    if (cnt.ContainsKey(value))
                    {
                        cnt[value]++;
                    }
                    else
                    {
                        cnt.Add(value, 1);
                    }
                }
                int mostCommonValue = 0;
                int highestCount = 0;
                foreach (KeyValuePair<int, int> pair in cnt)
                {
                    if (pair.Value > highestCount)
                    {
                        mostCommonValue = pair.Key;
                        highestCount = pair.Value;
                    }
                }
                Console.WriteLine(mostCommonValue+" ("+ highestCount+" times)");            
            }
        }
    }
}
