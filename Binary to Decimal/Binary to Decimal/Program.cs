using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_binary
{
    class Program
    {
        public static string ConvertFromDecToNumeralSystems(int value, int nBase)
        {
            string result = "";

            do
            {
                int digit = value % nBase;
                value /= nBase;

                result = digit + result;
            }
            while (value > 0);


            return result;
        }


        public static int ConvertToDec(string N, int nBase)
        {
            int result = 0;

            foreach (char digits in N)
            {
                result = result * nBase + (digits - '0');
            }

            return result;
        }

        static void Main()
        {
            string N = Console.ReadLine();            
            Console.WriteLine(ConvertToDec(N, 2));
        }
    }
}
