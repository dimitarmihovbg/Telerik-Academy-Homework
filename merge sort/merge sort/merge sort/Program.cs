using System;
using System.Collections.Generic;
using System.Linq;


namespace merge_sort
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
        }
    }
}
