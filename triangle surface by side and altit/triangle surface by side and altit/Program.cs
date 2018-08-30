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
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double resultOne = (side * altitude) / 2;
            double result = Math.Round(resultOne, 2);
            Console.WriteLine(result);
        }
    }
}
