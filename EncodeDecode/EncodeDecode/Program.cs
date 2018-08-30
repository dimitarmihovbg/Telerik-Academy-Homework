using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] cypher = { 'A', 'B', 'C', 'Z' };
            string[] resultedArray = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    resultedArray[i] = cypher[0].ToString();
                }
                else if(input[i] == 'b')
                {
                    resultedArray[i] = cypher[1].ToString();
                }
                else if (input[i] == 'c')
                {
                    resultedArray[i] = cypher[2].ToString();
                }
                else if (input[i] == 'z')
                {
                    resultedArray[i] = cypher[3].ToString();
                }
                else
                {
                    resultedArray[i] = input[i].ToString();
                }                
            }
            string result = "";
            foreach (var item in resultedArray)
            {
                result += item;
            }
            Console.WriteLine(result);
        }
    }
}
