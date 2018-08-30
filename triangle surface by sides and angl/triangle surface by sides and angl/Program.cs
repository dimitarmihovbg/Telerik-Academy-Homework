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
            double angleBetweenAandC = double.Parse(Console.ReadLine());
            double sinC = Math.Sin(angleBetweenAandC);
            if (a > b)
            {
                 sinC = 1 / (a / b);
            }
            else
            {
                 sinC = 1 / (b / a);
            }
            double Area = (a*b*sinC)/2;
            Console.WriteLine(Area);    
                 
        }
    }
}
