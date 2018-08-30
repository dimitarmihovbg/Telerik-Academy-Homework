using System;

namespace _10.NFactorial
{
    
    class Program
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            int result = 0;
            result = n * CalculateFactorial(n - 1);
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(n));
        }        
    }
}