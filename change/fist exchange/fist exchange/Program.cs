using System;

namespace fist_exchange
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
        }
    }
}
