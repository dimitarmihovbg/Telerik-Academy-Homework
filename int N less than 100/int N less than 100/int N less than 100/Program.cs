using System;

namespace int_N_less_than_100
{
    class MainBody
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            if (N <= 100)
            {
                bool prime = true;
                if (N == 1) prime = false;
                for (int i = 2; prime && i < N; i++)
                    if (N % i == 0) prime = false;
                if (prime) Console.WriteLine("prime");
                else Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("Sorry, the number you have put is More than 100");
            }              

        }
    }
}
