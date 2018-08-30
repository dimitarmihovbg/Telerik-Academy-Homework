using System;

namespace the_matrix
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N < 20)
                
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; i <= N; j++)
                    {
                        Console.Write(j+" ");
                        j++;
                    }
                   
                }
            }
        }
    }
}
