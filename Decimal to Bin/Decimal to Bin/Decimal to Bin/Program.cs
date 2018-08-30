using System;
using System.Collections.Generic;
using System.Linq;

namespace Decimal_to_Bin
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());            
            List<int> binary = new List<int>();

            while (N != 0)
            {
                    if (N % 2 == 0)
                    {
                        binary.Add(0);
                    }
                    else
                    {
                        binary.Add(1);
                    }
                N = N / 2;
            }                     
            for (int j = binary.Count - 1; j >= 0; j--)
            {
                Console.Write(binary[j]+" ");
            }            
        }
    }
}
