using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidden_message
{
    class Program
    {
        static void Main()
        {
            //while (Console.ReadLine() != "end")
            //{
                int I = int.Parse(Console.ReadLine());
                int S = int.Parse(Console.ReadLine());
                string subtitles = Console.ReadLine();
                int m = 0;
                List<string> codedLetters = new List<string>();
                for (int i = 0; m < subtitles.Length ; i ++)                
                {
                    for (m = I; m < subtitles.Length; m += S )
                    {
                    codedLetters[i] = Convert.ToString(subtitles[m] - '0');
                    }                    
                }
                for (int k = 0; k<codedLetters.Count; k++)
                {
                    Console.WriteLine(codedLetters[k]);
                }
                
            //}         
            
        }


    }
}
