using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_count
{
    class Program
    {
        public static int CountingAppearanceOfNum(int[] One, int x)
        {
            int counter = 0;
            for (int i = 0; i<One.Length; i++)
            {                
                if (x == One[i])
                {
                    counter++;
                }                        
            }
            return counter;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers our array shall be: ");
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];
            Console.WriteLine("Please Write {0} numbers seperated with Comma between each number", N);
            string input = Console.ReadLine();
            arr = input.Split(',');
            int[] resultedArray = Array.ConvertAll(arr, s => int.Parse(s));
            Console.WriteLine("Please enter the number we will search for:");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Number {0} is contained {1} times!",X,CountingAppearanceOfNum(resultedArray, X));      
            
            }
        }
}


