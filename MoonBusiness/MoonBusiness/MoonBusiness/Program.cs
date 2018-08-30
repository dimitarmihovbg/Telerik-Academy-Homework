using System;

namespace MoonBusiness
{
    class MainBody
    {
        static void Main()
        {
            double wEarth = Double.Parse(Console.ReadLine());
            double W = wEarth * 0.17;            
            Console.WriteLine(Math.Round(W, 3));


        }
    }
}
