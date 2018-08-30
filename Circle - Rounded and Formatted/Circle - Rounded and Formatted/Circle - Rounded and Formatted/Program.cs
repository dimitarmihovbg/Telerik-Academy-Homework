using System;

namespace Circle___Rounded_and_Formatted
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double circlePerimeter = 2 * (3.14159 * r);
            double circleArea = 3.14159 * (r * r);
            Console.WriteLine(Math.Round(circlePerimeter, 2)+" "+ Math.Round(circleArea, 2)); 
        }
    }
}
