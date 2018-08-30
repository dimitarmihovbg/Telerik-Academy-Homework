using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_numbers_exception_handling
{
    class Program
    {
        public static bool isItIncreasingAndValid(int[] arr, int start, int end)
        {
            bool result = false;         
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1] || arr[i] < start || arr[i] > end)
                {
                    result = true;                 
                }
                else
                {
                    result = false;                   
                }
            }         
            return result;
        }


        public static void ReadNumber(int start, int end)
         {
            string result = "";
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());               
            }
            
                try 
                {
                  if (isItIncreasingAndValid(array, start, end))
                {
                    foreach (var item in array)
                    {
                        result += " < " + item;
                    }
                    Console.WriteLine(start + result + " < " + end);                  
                } 
                  else
                {
                    throw new ArgumentException();
                }                                                              
            }
                catch(Exception)
                {
                    Console.WriteLine("Exception");
                }                         
         }
        static void Main(string[] args)
        {            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ReadNumber(a, b);         
            
            
            
        }
    }
}
