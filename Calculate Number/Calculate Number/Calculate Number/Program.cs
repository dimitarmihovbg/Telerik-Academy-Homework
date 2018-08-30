using System;

namespace Calculate_Number
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 0;
            double faktorelX = 1;           
            for (int intcount = 1; intcount <= x; intcount++)
            {
                faktorelX *= intcount;
            }
            Console.WriteLine(faktorelX);

             
            for (double j = 0; j<= N; j++)
            {
                double faktorelJ = 1;
                for (int intcount = 1; intcount <= j; intcount++)
                {
                    faktorelJ *= intcount;
                }
                double result = faktorelJ / Math.Pow(x, N);
                Console.WriteLine(result);

            }
        }
    }
}
