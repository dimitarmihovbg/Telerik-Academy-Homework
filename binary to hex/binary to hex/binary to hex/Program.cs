using System;

namespace binary_to_hex
{
    class Program
    {
        static void Main()
        {
            string N = Console.ReadLine();
            N.ToCharArray();
            double sum = 0;            
            for (int i = N.Length - 1; i >= 0; i--)
            {
                int m = Convert.ToInt32(new string(N[i], 1));                
                sum = sum + (m*(Math.Pow(2, ((N.Length - 1) - i))));               
            }
            Console.WriteLine(sum);
        }
    }
}
