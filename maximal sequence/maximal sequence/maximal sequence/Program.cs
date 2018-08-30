using System;
using System.Linq;

namespace maximal_sequence
{
    class MaximalSequence
    {
        static void Main()
        { 
                Console.Write("Enter a number N (size of array): ");
                int n = int.Parse(Console.ReadLine());
                int bestLength = 0, bestElement = 0;

                int[] numbers = new int[n];
                Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("   {0}: ", i + 1);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                int currentLength = 1, currentElement = numbers[0];

                bestElement = 0; bestLength = 0;

                if (numbers.Length == 1)
                {
                    bestElement = currentElement;
                    bestLength = 1;
                    return;
                }

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == currentElement)
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentElement = numbers[i];
                        currentLength = 1;
                    }

                    if (currentLength >= bestLength)
                    {
                        bestLength = currentLength;
                        bestElement = currentElement;
                    }                
                }
            Console.WriteLine(bestLength);

        }
    }
 }
    

