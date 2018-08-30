using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_area_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] neo = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                for (int entryNumber = 0; entryNumber < numbers.Length; entryNumber++)
                {
                    neo[i, entryNumber] = int.Parse(numbers[entryNumber]);
                }
            }
            int tempResult = 0;
            int totalResult = 0;
            for (int rol = 0; rol <= neo.GetLength(1) - 2; rol++)
            {               
                    for (int col = 0; col <= neo.GetLength(0) - 2; col++)
                    {                        
                            tempResult = neo[col, rol] + neo[col + 1, rol] + neo[col, rol + 1] + neo[col + 1, rol + 1];
                            if(totalResult < tempResult)
                            {
                                totalResult = tempResult;
                            }                        
                    }                           
            }
            if(totalResult > tempResult)
            {
                Console.WriteLine(totalResult);
            }
            else
            {
                Console.WriteLine(tempResult);
            }                                          
        }
    }
}
