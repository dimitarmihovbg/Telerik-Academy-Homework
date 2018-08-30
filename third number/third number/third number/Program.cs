using System;

namespace third_number
{
    class MainBody
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int proveriPyrvo = n / 100;
            int proveriVtoro = proveriPyrvo % 10;
            bool result = (proveriVtoro == 7);
            if (result == true)
            {
                Console.WriteLine("True");
            } 
            else
            {
                Console.WriteLine("false THIRD_DIGIT");
            }
        }
    }
}
