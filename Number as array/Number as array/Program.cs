using System;
using System.Linq;

namespace Number_as_array
{
    class MainClass
    {
        public static int NumAsArray(string inputOne, string inputTwo)
        {
            string[] arrStringOne = inputOne.Split(' ');
            string[] arrStringTwo = inputTwo.Split(' ');
            arrStringOne = arrStringOne.Select(l => String.Join(" ", l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();
            arrStringTwo = arrStringTwo.Select(l => String.Join(" ", l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();
            string arrStringOneWholeString = string.Join("", arrStringOne);
            string arrStringTwoWholeString = string.Join("", arrStringTwo);
            int arrIntegeredOne = int.Parse(arrStringOneWholeString);
            int arrIntegeredTwo = int.Parse(arrStringTwoWholeString);
            int result = arrIntegeredOne + arrIntegeredTwo;
            return result;
        }
        static void Main()
        {
            int sizeFirst = int.Parse(Console.ReadLine());
            int sizeSecond = int.Parse(Console.ReadLine());
            if (sizeFirst >= 0 && sizeSecond >= 0)
            {
                int[] arrOne = new int[sizeFirst];
                int[] arrTwo = new int[sizeSecond];
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();                                       
                Console.WriteLine(NumAsArray(inputOne,inputTwo));
            }
        }
    }
}
