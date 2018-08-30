using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] split = text.Split(' ');
        bool isItPalindrome = false;
        foreach (var item in split)
        {
            char[] ch = item.ToCharArray();
            for (int i = 0; i < ch.Length-1; i++)
            {
                if (ch[i] != ch[i + 1])
                {
                    isItPalindrome = false;
                }
                else
                {
                    isItPalindrome = true;
                }
            }
            if (isItPalindrome == true)
            {
                Console.WriteLine(item);
            }

        }
    }
}

