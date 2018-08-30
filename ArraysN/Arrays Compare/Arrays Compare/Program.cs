using System;
using System.Linq;

namespace Arrays_Compare
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N <= 20 && N >= 1)
            {
                int[] ArrayFirst = new int[N];
                int[] ArraySecond = new int[N];
                bool h = true;
                Console.WriteLine("Please input the first {0} numbers for ArrayFirst!", N);
                for (int i = 0; i < N; i++)
                {
                    ArrayFirst[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Good, Skywalker. Now, please put the other {0} numbers for ArraySecond!", N);
                for (int j = 0; j < N; j++)
                {
                    ArraySecond[j] = int.Parse(Console.ReadLine());
                }
                if (ArrayFirst.SequenceEqual(ArraySecond))
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not Equal"); 
                }                
            }
        }
    }
}
