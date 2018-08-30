using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {

        public static int GetMax(int numOne, int numTwo)
        {
            int result = 0;
            if (numOne > numTwo)
            {
                result = numOne;
            }
            else
            {
                result = numTwo;
            }
            return result;
        }


        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int getmaxedFirst = GetMax(a,b);
            
            if (getmaxedFirst > c)
            {
                Console.WriteLine(getmaxedFirst);
            }
            else
            {
                Console.WriteLine(c);
            }            
        }
    }
}
