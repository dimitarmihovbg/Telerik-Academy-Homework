using System;

class ShortToBinaryConvertion
{
    static void Main()
    {
        short shortNumber = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinary(shortNumber));
    }

    private static string ShortToBinary(short number)
    {
        string binaryNumber = string.Empty;

        // first way
        binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');

        // other way using Bitwise operations
        //for (int i = 15; i >= 0; i--)
        //{
        //    binaryNumber = ((number % 2) & 1) + binaryNumber;
        //    number >>= 1;
        //    //if (i % 4 == 0 && i != 0) binaryNumber = " " + binaryNumber;  // for better print
        //}

        return binaryNumber;
    }
}