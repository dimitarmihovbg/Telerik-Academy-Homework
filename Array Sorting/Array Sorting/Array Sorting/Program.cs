using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N <= 1024)
            {
                int[] arrayN = new int[N];
                for (int m = 0; m < N; m++)
                {
                    arrayN[m] = int.Parse(Console.ReadLine());
                }
                
                int N2 = arrayN.Length;
                for (int x = 0; x < N2; x++)
                {
                    int min_index = x;
                    for (int y = x; y < N2; y++)
                    {
                        if (arrayN[min_index] > arrayN[y])
                        {
                            min_index = y;
                        }
                    }
                    int temp = arrayN[x];
                    arrayN[x] = arrayN[min_index];
                    arrayN[min_index] = temp;
                }

                foreach (int i in arrayN)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
