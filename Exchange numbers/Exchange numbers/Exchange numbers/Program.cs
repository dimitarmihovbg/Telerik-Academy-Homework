using System;

namespace Exchange_numbers
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C;
            if ((A > -100) && (A < 100) && (B > -100) && (B < 100))
            {
                if (A > B)
                {
                    C = A;
                    A = B;
                    B = C;
                }
                Console.WriteLine(A+" "+B);
            }                            
        }
    }
}
