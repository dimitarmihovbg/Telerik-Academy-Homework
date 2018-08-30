using System;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Hex: {0:X}", a);
            string binary = Convert.ToString(a, 2);
            Console.WriteLine(binary.PadLeft(10, '0')+Math.Round(b, 2)+Math.Round(c, 3));
            Console.WriteLine(Math.Round(b, 2));
            Console.WriteLine(Math.Round(c, 3));
        }
    }
}
