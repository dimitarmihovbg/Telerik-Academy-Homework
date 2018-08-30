using System;

namespace circle
{
    class MainBody
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5) && y > 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("ne");
            }

        }
    }
}