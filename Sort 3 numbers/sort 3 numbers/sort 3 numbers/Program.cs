using System;

namespace sort3
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a > -1000) && (a < 1000) && (b > -1000) && (b < 1000) && (c > -1000) && (c < 1000))
            {
                if (a > b && a > c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                    else
                    {
                        Console.WriteLine(a + " " + c + " " + b);
                    }
                }
                if (b > a && b > c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine(b + " " + a + " " + c);
                    }
                    else
                    {
                        Console.WriteLine(b + " " + c + " " + a);
                    }
                }
                if (c >= a && c >= b)
                {
                    if (a >= b)
                    {
                        Console.WriteLine(c + " " + a + " " + b);
                    }
                    else
                    {
                        Console.WriteLine(c + " " + b + " " + a);
                    }
                }
            }
        }
    }
}
