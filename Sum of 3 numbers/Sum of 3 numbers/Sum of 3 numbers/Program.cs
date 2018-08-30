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

            if ((a >= -1000 && a <= 1000) && (b >= -1000 && b <= 1000) && (c >= -1000 && c <= 1000))
                {
                Console.WriteLine(a + b + c);
            }
            else
            {
                Console.WriteLine("Numbers are outside the range of -1000 do 1000. Please make the next input correct!");
            }
         }
    }
}
