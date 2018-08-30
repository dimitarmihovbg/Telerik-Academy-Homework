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
            string chosenWord = Console.ReadLine();
            string result = input.Replace(chosenWord, "").TrimStart();
            Console.WriteLine(result);

        }

    }
}
