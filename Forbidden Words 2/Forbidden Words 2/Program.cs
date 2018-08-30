using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] forbiddenWords = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder asterisksReplacedText = new StringBuilder();

        asterisksReplacedText.Append(text);

        foreach (string word in forbiddenWords)
        {
            // replace word with new string('*', word.Length)
            asterisksReplacedText.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(asterisksReplacedText);
    }
}