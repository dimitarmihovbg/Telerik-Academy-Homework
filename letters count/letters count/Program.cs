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
            var dict = new Dictionary<char, int>();
            for (int index = 0; index < input.Length; index++)
            {
                char theKey = input[index];
                if (!dict.ContainsKey(theKey))
                {
                    dict.Add(theKey, 1);
                }                    
                else
                {
                    dict[input[index]]++;
                }                    
            }
            foreach (var key in dict.Keys)
            {
                Console.WriteLine("The letter: {0} is contained {1} times.", key, dict[key]);
            }
        }
            static void Main(string[] args)
        {
            Letters();                    
        }
    }
}
