using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }
            double r = a % b;
            while (r != 0)
            {                
                a = b;
                b = r;
                r = a % b;
            }
           Console.WriteLine("GCD: " + b);
        }
    }
}
