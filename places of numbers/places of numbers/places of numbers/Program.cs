using System;

namespace places_of_numbers
{
    class MainBody
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 1000 && number <= 9999)
            {
                int a = number / 1000;
                int b = (number % 1000) / 100;
                int c = (number % 100) / 10;
                int d = number % 10;
                Console.WriteLine("The sum of all 4 digits = "+(a + b + c + d));
                Console.WriteLine(d + " " + c + " " + b + " " + a);
                Console.WriteLine(d + " " + a + " " + b + " " + c);
                Console.WriteLine(a + " " + c + " " + b + " " + d);
            }
            else
            {
                Console.WriteLine("Please input 4 digit number NEXT TIME");
            }
        }
    }
}
