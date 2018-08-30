using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_binary
{
    class Program
    {
        public static int HexToDec(string N)
        {
            int result = 0;

            foreach (char digit in N)
            {
                int digitValue;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }
                result = result * 16 + digitValue;
            }
            return result;

        }



        public static string DecToHex(int value)
        {
            string result = "";
            string hexDigits = "0123456789ABCDEF";
            do
            {
                int digitValue = value % 16;
                char digit = hexDigits[digitValue];
                value /= 16;

                result = digit + result;
            }
            while (value > 0);

            return result;
        }


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
            Console.WriteLine(HexToDec(N));
        }
    }
}
