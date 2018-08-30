using System;

namespace circle
{
    class MainBody
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x - 0) * (x - 0)) + ((y - 0) * (y - 0)) <= 4)
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
