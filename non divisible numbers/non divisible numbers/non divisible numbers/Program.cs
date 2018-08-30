using System;

namespace Non_Divisible_Numbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N > 1 && N < 1500)
            {
                for (int i = 1; i <= N; i++)
                {
                    if ((i % 3 != 0) && (i % 7 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            else Console.WriteLine("Please input N in the designated range between 1 & 1500");

        }
    }
}
