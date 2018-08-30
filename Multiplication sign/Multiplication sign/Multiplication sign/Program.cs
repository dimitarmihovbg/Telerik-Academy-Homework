using System;

namespace Multiplication_sign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a > 0) && (b > 0) && (c >0))
            {
                Console.WriteLine("+");
            }
            if ((a < 0) && (a < b) && (a < c))
            {
                Console.WriteLine("+");
            }
            if ((b < 0) && (a > b) && (c > b))
            {
                Console.WriteLine("+");
            }
        }
    }
}
