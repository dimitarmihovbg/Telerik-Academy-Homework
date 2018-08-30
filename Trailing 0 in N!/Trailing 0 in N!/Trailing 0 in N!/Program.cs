using System;


namespace Trailing_0_in_N_
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            long result = 1;
            long counter = 0;
            long factorel = 1;            
                factorel = 1;
                for (long j = N; j >= 1; j--)
                {
                    factorel *= j;
                }
                result += factorel;
            
            Console.WriteLine(factorel);
            while (factorel % 5 == 0)
            {
                if (factorel % 5 == 0 && factorel / 5 != 5)
                {
                    counter = counter + 1;
                    factorel = factorel / 5;
               }                
            }
           Console.WriteLine(counter);
        }
    }
}
