using System;
class FourMatrices
{
    static void Main()
    {
        Console.Write("Enter size of matrix N: ");
        Console.WriteLine("Enter the matrix variant (a, b, c  or  d):");
        int n = int.Parse(Console.ReadLine());
        string choice = Console.ReadLine();
        int[,] matrix = new int[n, n];              
        int counter;     
        counter = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = counter;
                counter++;
            }
        }
        if (choice == "a") 
        {
            PrintMatrix(n, matrix);
        }        
        counter = 1;
        for (int row = 0; row < n; row++)
            for (int col = 0; col < n; col++)
            {
                if (row % 2 == 0)
                {
                    matrix[col, row] = counter;
                }               
                else
                {
                    matrix[n - col - 1, row] = counter;
                }
                counter++;
            }
        if (choice == "b")
        {
            PrintMatrix(n, matrix);
        }        
        counter = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            int row = i;
            int col = 0;
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
                counter++;
            } while (row < n);
        }
        for (int i = 1; i < n; i++)
        {            
            int col = i;
            int row = 0;
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
                counter++;
            } while (col < n);
        }
        if (choice == "c")
        {
            PrintMatrix(n, matrix);
        }        
        int leftColumn = 0; 
        int rightColumn = n - 1; 
        int upperRow = 0; 
        int bottomRow = n - 1; 
        int count = 1; 
        do
        {
            for (int i = upperRow; i <= bottomRow; i++) 
            {
                matrix[i, leftColumn] = count;
                count++;
            }
            leftColumn++; 
            for (int i = leftColumn; i <= rightColumn; i++) 
            {
                matrix[bottomRow, i] = count;
                count++;
            }
            bottomRow--; 
            for (int i = bottomRow; i >= upperRow; i--) 
            {
                matrix[i, rightColumn] = count;
                count++;
            }
            rightColumn--; 
            for (int i = rightColumn; i >= leftColumn; i--) 
            {
                matrix[upperRow, i] = count;
                count++;
            }
            upperRow++; 
        } while (count <= n * n);
        if (choice == "d")
        {
            PrintMatrix(n, matrix);
        }
    }
    private static void PrintMatrix(int n, int[,] matrix)
    {

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {                
                Console.Write("{0,3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}