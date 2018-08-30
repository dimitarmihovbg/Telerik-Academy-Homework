using System;

namespace bigger_number_of_two
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The greater number is: {0}" + a);
            }
            else
            {
                Console.WriteLine("The greater number is: " + b);
            }
        }
    }
}
    

