using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters_count
{
    class Program
    {
        public static void Letters()
        {
            string input = Console.ReadLine();
            input.Trim();
            var dict = new Dictionary<char, int>();
            for (int index = 0; index < input.Length; index++)
            {
                char theKey = input[index];
                if (!dict.ContainsKey(theKey))
                {
                    dict.Add(theKey, 1);
                }
                                
            }
            string result = "";
            foreach (var key in dict.Keys)
            {
                result += key;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Letters();
        }
    }
}
