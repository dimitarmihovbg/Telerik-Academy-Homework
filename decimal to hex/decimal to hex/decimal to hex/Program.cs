using System;
using System.Collections.Generic;
using System.Linq;

namespace Decimal_to_Bin
{
    public class DecimalToHex
    {
        static void Main()
        {
            List<string> hexDigits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int decimalNumber = int.Parse(Console.ReadLine());
            List<string> hexNumber = new List<string>();

            while (decimalNumber != 0)
            {
                int indexFromDigits = decimalNumber % 16;
                hexNumber.Insert(0, hexDigits[indexFromDigits]);

                decimalNumber /= 16;
            }

            Console.WriteLine(string.Join("", hexNumber));
        }
    }
}
