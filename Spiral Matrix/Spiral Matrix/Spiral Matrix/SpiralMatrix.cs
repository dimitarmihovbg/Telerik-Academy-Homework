using System;

namespace SpiralMatrix
{
    public class SpiralMatrix
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            if (size < 1 || size > 20)
            {
                throw new ArgumentException("Number was outside the range");
            }

            int[,] matrix = new int[size, size];

            int[,] filledMatrix = FillMatrix(matrix, size);

            PrintMatrix(filledMatrix, size);
        }

        private static int[,] FillMatrix(int[,] matrix, int size)
        {
            int currentRow = 0;
            int currentCol = 0;
            Directions currentDirection = Directions.Right;
            int currentNumber = 1;

            while (true)
            {
                matrix[currentRow, currentCol] = currentNumber;
                bool fineshedOnThisDirection = false;
                if (currentDirection == Directions.Right)
                {
                    fineshedOnThisDirection = currentCol == size - 1 || matrix[currentRow, currentCol + 1] != 0;
                    if (fineshedOnThisDirection)
                    {
                        if (matrix[currentRow + 1, currentCol] != 0)
                        {
                            return matrix;
                        }

                        currentDirection = Directions.Down;
                        currentRow++;
                    }
                    else 
                    {
                        currentCol++;
                    }
                }
                else if (currentDirection == Directions.Down)
                {
                    fineshedOnThisDirection = currentRow == size - 1 || matrix[currentRow + 1, currentCol] != 0;
                    if (fineshedOnThisDirection)
                    {
                        if (matrix[currentRow, currentCol - 1] != 0)
                        {
                            return matrix;
                        }

                        currentDirection = Directions.Left;
                        currentCol--;
                    }
                    else
                    {
                        currentRow++;
                    }
                }
                else if (currentDirection == Directions.Left)
                {
                    fineshedOnThisDirection = currentCol <= 0 || matrix[currentRow, currentCol - 1] != 0;
                    if (fineshedOnThisDirection)
                    {
                        if (matrix[currentRow - 1, currentCol] != 0)
                        {
                            return matrix;
                        }

                        currentDirection = Directions.Up;
                        currentRow--;
                    }
                    else
                    {
                        currentCol--;
                    }
                }
                else if (currentDirection == Directions.Up)
                {
                    fineshedOnThisDirection = currentRow <= 0 || matrix[currentRow - 1, currentCol] != 0;
                    if (fineshedOnThisDirection)
                    {
                        if (matrix[currentRow, currentCol + 1] != 0)
                        {
                            return matrix;
                        }

                        currentDirection = Directions.Right;
                        currentCol++;
                    }
                    else
                    {
                        currentRow--;
                    }
                }
                else
                {
                    return matrix;
                }

                currentNumber++;
            }
        }

        private static void PrintMatrix(int[,] filledMatrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(filledMatrix[row, col].ToString().PadLeft(3, ' '));
                }

                Console.WriteLine();
            }
        }
    }
}
