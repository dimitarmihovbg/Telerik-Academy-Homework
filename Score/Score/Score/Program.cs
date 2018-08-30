
using System;

namespace Score
{
    class Program
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            if ((s > 9) || (s <= 0))
            {   
                Console.WriteLine("invalid score");
            }
            else
            {
                if ((s >= 1) && (s <= 3))
                {
                    s = s * 10;
                }
                if ((s >= 4) && (s <= 6))
                {
                    s = s * 100;
                }
                if ((s >= 7) && (s <= 9))
                {
                    s = s * 1000;
                }
                Console.WriteLine(s);
            }
        }
    }
}
