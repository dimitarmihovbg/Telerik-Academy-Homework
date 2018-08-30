using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the K number:");
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("\nEnter a {0} number(s) to array: ", N);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("   {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            int result = Array.BinarySearch(numbers, K);
            Console.WriteLine(result);

        }
    }
}
