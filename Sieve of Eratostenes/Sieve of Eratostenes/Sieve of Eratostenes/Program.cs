using System;
using System.Collections;
using System.Collections.Generic;
 
namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxprime = int.Parse(Console.ReadLine());
            var primelist = GetAllPrimesLessThan(maxprime);
            Console.WriteLine(primelist[primelist.Count -1]);             
        }
 
        private static List<int> GetAllPrimesLessThan(int maxPrime)
        {
            var primes = new List<int>();
            var maxSquareRoot = (int)Math.Sqrt(maxPrime);
            var eliminated = new BitArray(maxPrime + 1);
 
            for (int i = 2; i <= maxPrime; ++i)
            {
                if (!eliminated[i])
                {
                    primes.Add(i);
                    if (i <= maxSquareRoot)
                    {
                        for (int j = i * i; j <= maxPrime; j += i)
                        {
                            eliminated[j] = true;
                        }
                    }
                }
            }
            return primes;
        }
    }
}