using System;

namespace Sum_of_N_numbers
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double sum = 0;
            if ((1 <= N) && (N <= 200))
            {
                for (int i = 1; i <= N; i++)
                {
                    double N2 = double.Parse(Console.ReadLine());
                    sum += N2;
                }
                Console.WriteLine(sum);
            }

            else Console.WriteLine("Please input N in the designated range between 1 & 1000");

        }
    }
}
