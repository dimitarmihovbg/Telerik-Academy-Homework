using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double x1;
            double x2;
            x1 = (-b) + (Math.Sqrt((b * b) - (4 * a * c))) / (2*a);
            x2 = (-b) - (Math.Sqrt((b * b) - (4 * a * c))) / (2*a);
            Console.WriteLine("x = "+x1+" x2 = "+x2);
        }
    }
}
