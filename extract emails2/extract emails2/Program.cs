using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] split = text.Split(' ');
        foreach (var item in split)
        {
            bool isItFoundKliomba = false;
            bool isItFoundDot = false;
            char[] ch = item.ToCharArray();
            for (int i = 1; i < ch.Length - 1; i++)
            {
                if (ch[i] == '@')
                {
                    isItFoundKliomba = true;
                }
                if (ch[i] == '.' && isItFoundKliomba)
                {
                    isItFoundDot = true;
                }
            }
            if( isItFoundDot && isItFoundKliomba )
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}

