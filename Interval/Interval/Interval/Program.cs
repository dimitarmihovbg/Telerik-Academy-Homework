using System;

namespace Interval
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            if ((2000 >= M) && (M >= N) && (N >= 0))
            {
                for (int i = N; i < M; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }                                     
                }
            }
            else
            {
                Console.WriteLine("Please put number between 2000 and 0");
            }
        }
    }
}
