using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordMethod
{
    class Program
    {
        public static string EnglishEnding(int a)
        {
            string result = "justStarting";
            if (a == 0)
            {
                result = "Zero";
            }
            else if (a == 1)
            {
                result = "One";
            }
            else if (a == 2)
            {
                result = "Two";
            }
            else if (a == 3)
            {
                result = "Three";
            }
            else if (a == 4)
            {
                result = "Four";
            }
            else if (a == 5)
            {
                result = "Five";
            }
            else if (a == 6)
            {
                result = "Six";
            }
            else if (a == 7)
            {
                result = "Seven";
            }
            else if (a == 8)
            {
                result = "Eight";
            }
            else if (a == 9)
            {
                result = "Nine";
            }
            return result;
        }


        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = number % 10;
            Console.WriteLine(EnglishEnding(a));
        }
    }
}
