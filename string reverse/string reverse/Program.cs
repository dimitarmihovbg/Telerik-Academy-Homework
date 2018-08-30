using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            string[] resultedArray = new string[inputArray.Length];
            Array.Reverse(inputArray);
            string result = "";
            foreach (var item in inputArray)
            {
                result += " " + item;
            }
            
            Console.WriteLine(result);

        }
    }
}
