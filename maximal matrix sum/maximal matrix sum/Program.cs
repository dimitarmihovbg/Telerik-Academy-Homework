using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximal_matrix_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N,M];         

            for (int rol = 0; rol < N; rol++)
            {
                string firstRol = Console.ReadLine();
                string[] values = firstRol.Split(' ');
                for (int col = 0; col < M; col++)
                {
                    matrix[rol, col] = int.Parse(values[col]);                   
                    //for (int lol = 1; lol < counterLol; lol++)
                    //{
                    //    Console.Write("   ");
                        
                    //}
                    //Console.CursorTop = Console.CursorTop - 1;                                      
                }
                Console.WriteLine();
            }
            int bestSum = 0;
            int currentSum = 0; 
            if (M <= 3 && N <= 3)
            {
                bestSum = matrix[0, 0] + matrix[1, 0] + matrix[0, 1] + matrix[0, 2] + matrix[2, 0] + matrix[1, 1] + matrix[2, 1] + matrix[1, 2] + matrix[2, 2];
            }
            else
            {
                for (int rol = 0; rol < N - 3; rol++)
                {
                    for (int col = 0; col < M - 3; col++)
                    {
                        currentSum = matrix[rol, col] + matrix[rol + 1, col] + matrix[rol, col + 1] + matrix[rol, col + 2] + matrix[rol + 2, col] + matrix[rol + 1, col + 1] + matrix[rol + 2, col + 1] + matrix[rol + 1, col + 2] + matrix[rol + 2, col + 2];
                        if (bestSum <= currentSum)
                        {
                            bestSum = currentSum;
                        }
                    }
                }
            }            
            Console.WriteLine(bestSum);     
        }
    }
}
