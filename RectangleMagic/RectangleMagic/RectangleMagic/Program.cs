using System;

namespace RectangleMagic
{
    class MainBody
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double area = width * length;
            double perimeter = 2 * (width + length);
            Console.WriteLine(Math.Round(area, 2)+" "+Math.Round(perimeter, 2));

        }
    }
}
