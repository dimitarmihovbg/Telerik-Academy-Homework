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
            string[] inputArray = input.Split(' ');
            var dict = new Dictionary<string, int>();
            for (int index = 0; index < inputArray.Length; index++)
            {
                string theKey = inputArray[index];
                if (!dict.ContainsKey(theKey))
                {
                    dict.Add(theKey, 1);
                }
                else
                {
                    dict[inputArray[index]]++;
                }
            }
            foreach (var key in dict.Keys)
            {
                Console.WriteLine("The word: {0} is contained {1} times.", key, dict[key]);
            }
        }
        static void Main(string[] args)
        {
            Letters();
        }
    }
}
