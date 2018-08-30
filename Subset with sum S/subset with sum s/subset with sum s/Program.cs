using System;
using System.Linq;

namespace sequence_sum
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter subset K: ");
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter sum  S: ");
            int sum = int.Parse(Console.ReadLine());
            int sum2 = 0;
                       
            for (int m = 0; m < n; m++)
            {
                for (int i = m; i < K; i++)
                {
                    if (sum == sum2)
                    {
                        goto endOfLoop;
                    }
                    else
                    {
                        sum2 += arr[i];
                    }                    
                }                
            }
            endOfLoop:
            Console.WriteLine("yes");                        
        }
    }
}