using System;

namespace Calculate_Again
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int factorel = 1;
            double result = 1;
            if (N > K && N < 100 && K > 1)
                for (int i = 1; i <= N; i++)
                {
                    factorel = 1;
                    for (int j = i; j >= 1; j--)
                    {
                        factorel *= j;
                    }
                    result += factorel / Math.Pow(X, i);
                }
            Console.WriteLine(result);
        }
    }
}
