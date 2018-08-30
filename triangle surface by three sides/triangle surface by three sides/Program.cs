using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_surface_by_side_and_altit
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double S = (a + b + c) / 2;
                double Area = Math.Sqrt(S * (S - a) * (S - b) * (S - c));
                double result = Math.Round(Area, 2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Your sides' lengths do not form a triangle");
            }            
        }
    }
}
