using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_dictionary
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            StringBuilder MyStringBuilder = new StringBuilder();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Equals("Hello"))
                {
                    MyStringBuilder.Append("Ko Staa");
                }
                else if (inputArray[i].Equals("dear"))
                {
                    MyStringBuilder.Append("ve lek");
                }
                else
                {
                    MyStringBuilder.Append(inputArray[i]);
                }                
            }
            Console.WriteLine(MyStringBuilder);     
        }
    }
}
