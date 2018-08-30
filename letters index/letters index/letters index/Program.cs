using System;
using System.Linq;

namespace LettersIndex
{
    class LettersIndex
    {
        static void Main()
        {
            Console.Write("Enter the number X: ");
            string X = Console.ReadLine();
            string[] letters = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p",
                "q","r","s","t","u","v","w","x","y","z"};   
            for (int i = 0; i<letters.Length; i++)
            {
                if (letters[i] == X)
                {
                    Console.WriteLine(i);
                }
            }            
        }
    }
}
