using System;


namespace Odd_and_Even
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());   
            if (N > 4 && N < 40)
            {
                int[] products = new int[N];
                int sumODD = 1;
                int sumEVEN = 1;
                for (int i = 0; i < N; i++)
                {
                    products[i] = int.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        sumODD = products[i] * sumODD;
                    }
                    else
                    {
                        sumEVEN = products[i] * sumEVEN;
                    }
                }
                if (sumODD == sumEVEN)
                {
                    Console.WriteLine("yes {0} ",sumODD);
                }
                else
                {
                    Console.WriteLine("no {0} {1}",sumODD,sumEVEN);
                }
                
            }                  
           
        }
    }
}
