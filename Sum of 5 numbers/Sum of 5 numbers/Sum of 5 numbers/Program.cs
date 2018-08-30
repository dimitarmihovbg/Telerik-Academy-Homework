using System;

namespace Sum_of_3_numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            if ((a >= -1000 && a <= 1000) && (b >= -1000 && b <= 1000) && (c >= -1000 && c <= 1000) && (e >= -1000 && e <= 1000) && (f >= -1000 && f <= 1000))
            {
                Console.WriteLine(a + b + c + e + f);
            }
            else
            {
                Console.WriteLine("One or more of the numbers are outside the range of -1000 to 1000. Please make the next input correct!");
            }
        }
    }
}
