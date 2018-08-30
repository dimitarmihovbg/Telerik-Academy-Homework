using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int[] resultsMix = new int[N-1];
            int[] resultsSubstract = new int[N-1];
            for (int i = 0; i<N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 10 || numbers[i] > 99)
                {
                    Console.WriteLine("Sorry, mate... Ain't no Two Digits number here!");
                    break;
                }
            }
            int tempOne = 0;
            int tempTwo = 0;
            for (int k = 0; k< numbers.Length -1; k++)
            {
                tempOne = numbers[k] % 10;
                tempTwo = numbers[k + 1] / 10;
                resultsMix[k] = tempOne * tempTwo;
                if (numbers[k] > numbers[k+1])
                {
                    resultsSubstract[k] = numbers[k] - numbers[k + 1];
                }
                else
                {
                    resultsSubstract[k] = numbers[k+1] - numbers[k];
                }
            }
            foreach (int resOne in resultsMix)
            {
                Console.Write(resOne+" ");
            }
            Console.WriteLine();
            foreach (int resTwo in resultsSubstract)
            {
                Console.Write(resTwo + " ");
            }
            Console.WriteLine();
        }
    }
}
