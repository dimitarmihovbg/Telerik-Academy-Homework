using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Calculations
{
    class Program
    {

        public static void Calculations(int[] array)
        {
            int minimum = 0;
            int maximum = 0;
            double sum = 0;
            int product = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i+1])
                {
                    minimum = array[i];
                }
                if (array[i] > array[i + 1])
                {
                    maximum = array[i];
                }
                sum += array[i];
                product *= array[i];
            }
            double avarage = sum / array.Length;
            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine(avarage);
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {           
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Calculations(arr);
        }
    }
}
