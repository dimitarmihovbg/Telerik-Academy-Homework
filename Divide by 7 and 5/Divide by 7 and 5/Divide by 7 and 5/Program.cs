using System;

namespace Divide_by_7_and_5
{
    class MainBody
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool result = (a % 5 == 0) && (a % 7 == 0);
            if (result == true)
            {
                Console.WriteLine("true "+a);
            }
            else
            {
                Console.WriteLine("false "+a);
            }


        }
    }
}
