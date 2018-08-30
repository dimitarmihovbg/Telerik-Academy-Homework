using System;

namespace hello_world_again
{
    class Program
    {
        static void Main()
        {
            string h = "Hello";
            string w = "World";
            object Sum = h + " " + w;
            string third = Convert.ToString(Sum);
            Console.WriteLine(third);

        }
    }
}
