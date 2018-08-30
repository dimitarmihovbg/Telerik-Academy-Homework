using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int N = int.Parse(Console.ReadLine());               
            string[] arr = new string[N];
            Console.WriteLine("\nEnter a {0} strings(s) to array: ", N);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("   {0}: ", i + 1);
                arr[i] = Console.ReadLine();
            }
            arr = arr.OrderBy(aux => aux.Length).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
