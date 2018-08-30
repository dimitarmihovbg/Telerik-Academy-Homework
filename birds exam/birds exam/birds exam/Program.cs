using System;

namespace birds_exam
{
    class Program
    {
        static void Main()
        {
            double B = int.Parse(Console.ReadLine());
            double F = int.Parse(Console.ReadLine());
            double avarage = (F / B);
            double evenBirdsResult = avarage * 123123123123;            
            double oddBirdsResult = avarage / 317;          
            if (B % 2 == 0) 
            {
                Console.WriteLine(Math.Round(evenBirdsResult, 4));
            }
            else
            {
                Console.WriteLine(Math.Round(oddBirdsResult, 4));
            }
            
        }
    }
}
