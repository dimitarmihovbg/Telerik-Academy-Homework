using System;

class TheSequenceNumbers
{
    static void Main()
    {
        int numbers;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numbers = i;
            }
            else
            {
                numbers = i * (-1);
            }
            Console.WriteLine(numbers);
        }
    }
}