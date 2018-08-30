using System;

namespace Odd_or_Even
{
    class MainBody
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if ((a & 1) == 0)
            {
                Console.WriteLine("Even");
            }
            else
            { 
                Console.WriteLine("Odd");
        }

        }
    }
}
