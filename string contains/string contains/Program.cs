using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        public static int TimesContainedStrng(string input, string checkForThis)
        {
            int result = 0;
            input.ToLower();
            result = Regex.Matches(Regex.Escape(input), checkForThis).Count;
            return result;
        }

        static void Main()  
        {
            string checkForThis = Console.ReadLine();
            string inputString = Console.ReadLine();            
            Console.WriteLine(TimesContainedStrng(inputString, checkForThis));
        }
    }
}
