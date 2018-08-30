using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_array
{
    class Program
    {
        public static IList JustSort(IList arrayToSort)
        {
            int n = arrayToSort.Count - 1;
            for (int i = 0; i < n; i++)
            {

                for (int j = n; j > i; j--)
                {
                    if (((IComparable)arrayToSort[j - 1]).CompareTo(arrayToSort[j]) > 0)
                    {
                        object temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
            return arrayToSort;
        }


        public static int Biggest(int[] array)
        {
            int currentBest = array[0];
            int currentIndex = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] > currentBest)
                {
                    currentBest = array[i];
                    currentIndex = i;
                }                
            }
            return currentBest;
            
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] defArray = new int[N];
            string input = Console.ReadLine();
            string[] inputArray= input.Split(' ');            
            for (int i = 0; i < defArray.Length; i++)
            {                
                    defArray[i] = int.Parse(inputArray[i]);                
            }
            Console.WriteLine(Biggest(defArray));
            JustSort(defArray);
            foreach (var item in defArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
