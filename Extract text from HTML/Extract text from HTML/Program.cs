using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_text_from_HTML
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] babati = input.Split(new string[] { ">", "<" }, StringSplitOptions.None);

            for (int item = 0; item < babati.Length; item++)
            {
                if (babati[item] == "title")
                {
                    Console.WriteLine(babati[item + 1]);
                }
            }

            string[] text = input.Split(new string[] { "/" }, StringSplitOptions.None);
            
        }
    }
}
