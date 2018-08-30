using System;

namespace Numbers_from_1_to_N
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if ((1 <= N) && (N < 1000))
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(i);
                }
            }
                       
                else Console.WriteLine("Please input N in the designated range between 1 & 1000");
            
        }
    }
}
