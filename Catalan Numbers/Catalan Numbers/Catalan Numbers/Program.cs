using System;

namespace Catalan
{
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int CatalanN = 1;
            int Term = 0;
            while (N-- > 1)
            {
                Term++;
                CatalanN = CatalanN * (4 * Term + 2) / (Term + 2);
            }
            Console.WriteLine(CatalanN);
        }
        }
    }


