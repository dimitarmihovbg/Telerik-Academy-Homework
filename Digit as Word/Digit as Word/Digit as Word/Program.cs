using System;

namespace Digit_as_Word
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0 && a <= 9)
            {
                if (a == 0)
                {
                    Console.WriteLine("Zero");
                }
                if (a == 1)
                {
                    Console.WriteLine("One");
                }
                if (a == 2)
                {
                    Console.WriteLine("Two");
                }
                if (a == 3)
                {
                    Console.WriteLine("Three");
                }
                if (a == 4)
                {
                    Console.WriteLine("Four");
                }
                if (a == 5)
                {
                    Console.WriteLine("Five");
                }
                if (a == 6)
                {
                    Console.WriteLine("Six");
                }
                if (a == 7)
                {
                    Console.WriteLine("Seven");
                }
                if (a == 8)
                {
                    Console.WriteLine("Eight");
                }
                if (a == 9)
                {
                    Console.WriteLine("Nine");
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
