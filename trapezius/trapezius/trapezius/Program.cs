using System;

namespace trapezius
{
    class MainBody
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = ((a + b) / 2) * h;
            Console.WriteLine(Math.Round(result, 7));   
        }
    }
}
