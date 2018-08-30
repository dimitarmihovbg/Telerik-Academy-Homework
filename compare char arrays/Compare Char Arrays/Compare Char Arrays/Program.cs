using System;
using System.Linq;

namespace ArraysOFCharsCompare
{
    class ArraysOFCharsCompare
    {
        static void Main()
        {
            Console.WriteLine("Enter first word: ");
            string arrayOne = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string arrayTwo = Console.ReadLine();
            if (arrayOne.SequenceEqual(arrayTwo))
            {
                Console.WriteLine("=");
            }
            else
            {
                if (arrayOne.Length > arrayTwo.Length)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine(">");
                }
            }
        }
     }
 }

