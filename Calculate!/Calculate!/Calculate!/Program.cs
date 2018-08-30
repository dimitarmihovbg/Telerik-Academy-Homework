using System;

namespace Calculate_
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            int factorel = 1;
            double result = 1;
            if ((N >= 2 && N <= 10) && (X > 0.5 && X < 100))
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
