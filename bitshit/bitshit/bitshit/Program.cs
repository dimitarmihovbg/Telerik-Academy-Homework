using System;

namespace bitshit
{
    class bitshit
    {
        static void Main()
        {
            uint b = uint.Parse(Console.ReadLine());
            b = b >> 2;
            uint c = 1;
            uint d = c & b;

            if (d == 1)
            {
                Console.WriteLine("It is 1");
            }
            else
            {
                Console.WriteLine("It is 0");
            }

        }
    }
}
