using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_digits_method
{
    class Program
    {

        public static void Reverse(decimal input)
        {
            string str = input.ToString("");
            str.Split();
            string[] arr = str.Split(',');
            string firstPart = arr[0];
            string lastPart = arr[1];
            char[] ReversedFirst = firstPart.ToCharArray();
            Array.Reverse(ReversedFirst);
            char[] ReversedLast = lastPart.ToCharArray();
            Array.Reverse(ReversedLast);
            string FirstString = new string(ReversedLast);
            string SecondString = new string(ReversedFirst);
            string Combined = FirstString + "," + SecondString;
            decimal resultFinally = decimal.Parse(Combined);
            Console.WriteLine(resultFinally);
        }


        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());
            Reverse(input);                    
        }
    }
}
