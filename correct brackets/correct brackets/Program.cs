using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        public static string CorrectOrNotBrackets(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')') 
                {
                    result = "Incorrect";
                    break;
                }
                else if (input[i] == '(')
                {
                    result = "Correct";
                    break;
                }              
            }
            return result;
        }

        static void Main()
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(CorrectOrNotBrackets(inputString));
        }
    }
}
