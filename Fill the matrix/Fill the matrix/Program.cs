using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            int[,] matrix = new int[N,N];
            int counter = 1;
            int aCol = 0;
            int aRow = 0;
            if (N >= 1 && N <= 128)
            {
                if (b == "a")
                {
                    for (aCol = 0; aCol < N; aCol++)
                    {
                        for (aRow = 0; aRow < N; aRow++)
                        {
                            matrix[aCol,aRow] = counter;
                            counter++;
                        }
                    }
                    for (aRow = 0; aRow < N; aRow++)
                    {
                        for (aCol = 0; aCol < N; aCol++)
                        {
                            Console.Write(matrix[aCol,aRow] + " ");                            
                        }
                        Console.WriteLine();
                    }
                }
                if (b == "c")
                {

                    for (aCol = 0; aCol < N; aCol++)
                    {
                        for (aRow = 0; aRow < N; aRow++)
                        {
                            matrix[aCol, aRow] = counter;
                            counter++;
                        }
                    }
                    for (aRow = 0; aRow < N; aRow++)
                    {
                        for (aCol = 0; aCol < N; aCol++)
                        {
                            Console.Write(matrix[aCol, aRow] + "  ");
                        }
                        Console.WriteLine();
                    }

                }
                if (b == "b")
                {

                    for (aCol = 0; aCol < N; aCol++)
                    {
                        for (aRow = 0; aRow < N; aRow++)
                        {
                            matrix[aCol, aRow] = counter;
                            counter++;
                        }
                    }
                    
                    for (int order = 0; order < N - 1; order++)
                    {
                        while (order % 2 == 0 && aCol >= 0)
                        {
                            for (aRow = 0; aRow < N; aRow++)
                            {
                                for (aCol = N-1; aCol >= 0; aCol--)
                                {
                                    Console.Write(matrix[aCol, aRow]+"  ");
                                }
                                Console.WriteLine();
                            }
                        }
                        while (order % 2 != 0)                      
                        {
                                for ( aRow = 0; aRow < N; aRow++)
                                {
                                    for ( aCol = 0; aCol < N; aCol++)
                                    {
                                        Console.Write(matrix[aCol, aRow] + "  ");
                                    }
                                    Console.WriteLine();
                                }
                            }                        
                    }
                }
                if (b == "d")
                {

                    for (aCol = 0; aCol < N; aCol++)
                    {
                        for (aRow = 0; aRow < N; aRow++)
                        {
                            matrix[aCol, aRow] = counter;
                            counter++;
                        }
                    }
                    for (aRow = 0; aRow < N; aRow++)
                    {
                        for (aCol = 0; aCol < N; aCol++)
                        {
                            Console.Write(matrix[aCol, aRow] + "  ");
                        }
                        Console.WriteLine();
                    }

                }
            }          
        }
    }
}
