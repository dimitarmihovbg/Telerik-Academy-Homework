using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_binary
{
    class Program
    {

        public static Dictionary<char, string> HexToBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }

        };

        public static string HexToBin(string hexNumber)
        {          

            StringBuilder decimalRepresentation = new StringBuilder();

            foreach (var digit in hexNumber)
            {
                decimalRepresentation.Append(HexToBinaryTable[digit]);
            }

            return (decimalRepresentation.ToString().Substring(decimalRepresentation.ToString().IndexOf('1'), decimalRepresentation.ToString().Length - decimalRepresentation.ToString().IndexOf('1')));

         
        }


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


        public static string ConvertFromDecToNumeralSystems(int value, int nBase) //fromDecToBinUsed
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


        public static int ConvertToDec(string N, int nBase) //fromBintoDecUsed
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
            string N = (Console.ReadLine());
            Console.WriteLine(HexToBin(N));
        }
    }
}
