using System;

namespace Biggest_of_Three
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a > -200) && (a < 200) && (b > -200) && (b < 200) && (c > -200) && (c < 200))
            {
                if ((a > b) && (a > c))
                {
                    Console.WriteLine(a);
                }
                if ((b > a) && (b > c))
                {
                    Console.WriteLine(b);
                }
                if ((c > b) && (c > a))
                {
                    Console.WriteLine(c);
                }
                if ((a == b) && (b == c))
                {
                    Console.WriteLine(a);
                }
                if ((a == b) && (b > c))
                {
                    Console.WriteLine(b);
                }
                if ((a > b) && (b == c))
                {
                    Console.WriteLine(a);
                }
                if ((a == b) && (b < c))
                {
                    Console.WriteLine(c);
                }
                if ((a == c) && (b < c))
                {
                    Console.WriteLine(a);
                }
                if ((c == b) && (a < c))
                {
                    Console.WriteLine(b);
                }
            }
         }
    }
}
