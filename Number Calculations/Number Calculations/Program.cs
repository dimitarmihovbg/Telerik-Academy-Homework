using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Calculations
{
    class Program
    {

        static void Calculations<T>(T[] array)
        {
            var minimum = 0;
            var maximum = 0;
            double sum = 0;
            var product = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                    
                if ( value.Com(array[i + 1]))
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
