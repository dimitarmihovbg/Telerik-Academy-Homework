using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence_in_matrix
{
    class Program
    {
        static void Main()
        {
            string[] inputArr = new string[2];
            inputArr = Console.ReadLine().Split(' ');
            int currentCounter = 1;
            int bestCounter = 1;
            int longestCounter = 1;
            int N = int.Parse(inputArr[0]);
            int M = int.Parse(inputArr[1]);
            int[,] arr = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] strInput = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = int.Parse(strInput[j]);
                }
            }
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M - 1; col++)
                {
                    if (arr[row, col] == arr[row, col + 1])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                        if (bestCounter < longestCounter)
                        {
                            bestCounter = longestCounter;
                        }
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                currentCounter = 1;
            }
            currentCounter = 1;
            longestCounter = 1;
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < M - 1; row++)
                {
                    if (arr[row, col] == arr[row + 1, col])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                        if (bestCounter < longestCounter)
                        {
                            bestCounter = longestCounter;
                        }
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                currentCounter = 1;
            }
            int currcol = 1;

            for (int col = 0; col < N - 1; col++)
            {
                for (int row = 0; col < M - 1 && row < N - 2; col++, row++)
                {
                    if (arr[row, col] == arr[row + 1, col + 1])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                if (bestCounter < longestCounter)
                {
                    bestCounter = longestCounter;
                }                

            }
            for (int col = N-1; col >= 0; col--)
            {
                for (int row = 0; col > 0 && row < N - 1; col--, row++)
                {
                    if (arr[row, col] == arr[row + 1, col - 1])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                if (bestCounter < longestCounter)
                {
                    bestCounter = longestCounter;
                }                
            }

            for (int row = 1; row < N -1; row++)
            {
                for (int col = N-1; col > 0 && row < N - 1; col--, row++)
                {
                    if (arr[row, col] == arr[row + 1, col - 1])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                if (bestCounter < longestCounter)
                {
                    bestCounter = longestCounter;
                }
            }

            for (int row = 1; row < N - 1; row++)
            {
                for (int col = 0; col <N-1 && row < N - 1; col++, row++)
                {
                    if (arr[row, col] == arr[row + 1, col +1])
                    {
                        currentCounter++;
                        longestCounter = currentCounter;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (bestCounter < longestCounter)
                    {
                        bestCounter = longestCounter;
                    }
                }
                if (bestCounter < longestCounter)
                {
                    bestCounter = longestCounter;
                }
            }

            Console.WriteLine(bestCounter);
        }
    }
}
