using System;

namespace Larger_than_neighbours
{
    class FirstClass
    {

        public static int CheckFirstWinnerAmongNeighbours(int[] array)
        {
            int resultedIndex = -1;
            for (int i = 1; i < array.Length - 2; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    resultedIndex = i;
                }
            }
            return resultedIndex;
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];
            string input = Console.ReadLine();
            arr = input.Split(',');
            int[] resultedArray = Array.ConvertAll(arr, s => int.Parse(s));
            if ((resultedArray.Length == 0) | (arr.Length == 1))
            {
                Console.WriteLine("-1");
            }
            else if (resultedArray.Length > 1)
            {
                Console.WriteLine(CheckFirstWinnerAmongNeighbours(resultedArray));
            }
        }
    }
}
