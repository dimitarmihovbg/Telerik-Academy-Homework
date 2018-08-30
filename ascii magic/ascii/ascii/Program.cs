using System;

namespace ascii
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 33; i < 127; i++)
            {
                char symbol = (char)i;
                Console.Write("{0} -> {1}", i, symbol);

            }
        }
    }
}