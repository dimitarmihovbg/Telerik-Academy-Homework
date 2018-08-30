using System;

namespace Comparing_Floats
{ 
    class MainBody
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a - b;
            if (c > 0.000001)
            {
                Console.WriteLine(false);
            }
            else
            { 
                Console.WriteLine(true);
            }


            }
        }
    }

