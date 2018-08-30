using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            Array.Sort(inputArray);
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
            


        }
    }
}
