using System;
using System.Linq;


namespace BINARY_SEARCH
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());            
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number X: ");
            int X = int.Parse(Console.ReadLine());
            var sorted = arr.OrderBy(i => i).ToArray();

            int index2 = Array.BinarySearch(sorted, X);
            Console.WriteLine(index2);
         }
    }
}
