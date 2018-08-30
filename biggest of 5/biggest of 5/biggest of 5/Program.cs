using System;

namespace Biggest_of_5
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            if ((a > -200) && (a < 200) && (b > -200) && (b < 200) &&
                    (c > -200) && (c < 200) && (d > -200) && (d < 200) && (f > -200) && (f < 200))
            {                
                Console.WriteLine(Math.Max((Math.Max((Math.Max(Math.Max(a, b), c)), d)), f));
            }
         }
    }
}
