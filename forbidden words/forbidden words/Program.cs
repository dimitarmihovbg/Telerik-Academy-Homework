using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();           
            string result = input.Replace("Microsoft", "**********").TrimStart();
            string result2 = result.Replace("PHP", "***").TrimStart();   
            Console.WriteLine(result2);

        }

    }
}
