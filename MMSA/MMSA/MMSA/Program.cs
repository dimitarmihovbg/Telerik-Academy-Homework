using System;
using System.Linq;

namespace MMSA
{
    class Program
    {
        static void Main()
        {

            {
                int n = int.Parse(Console.ReadLine());

                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    if (array[i] < 10000 && array[i] > -10000)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    
                }

                Console.WriteLine("min = {0}", array.Min());
                Console.WriteLine("max = {0}", array.Max());
                Console.WriteLine("sum = {0}", array.Sum());
                Console.WriteLine("avg = {0:F2}", array.Average());
            }
        }
    }
}



