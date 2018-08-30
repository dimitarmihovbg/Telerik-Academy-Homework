using System;


namespace compare_char_rarrays2
{
    class Program
    {
        static void Main()
        {
            string N1 = Console.ReadLine();
            string N2 = Console.ReadLine();
            if ((N1.Length <= 128 && N1.Length >= 1) && (N2.Length <= 128 && N2.Length >= 1))
              {
                char[] arrayN1 = new char[N1.Length];
                char[] arrayN2 = new char[N2.Length];
                int counter1 = 0;
                int counter2 = 0;
                for (int i = 0; i < N1.Length; i++)
                {
                    counter1++;
                }
                for (int j = 0; j < N2.Length; j++)
                {
                    counter2++;
                }
                if (counter1 == counter2)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    if (counter1 < counter2)
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine(">");
                    }
                }
            }
        }
    }
}
