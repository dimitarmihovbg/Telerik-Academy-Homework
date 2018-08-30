using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            int pyrviChlen = 0;
            int vtoriChlen = 1;
            Console.WriteLine(pyrviChlen);
            Console.WriteLine(vtoriChlen);
            if ((N >= 1) && (N <= 50))
            {
                for (int i = 0; i <= N; i++)
                {
                    int sledvashtChlen = pyrviChlen + vtoriChlen;
                    Console.WriteLine(sledvashtChlen);
                    pyrviChlen = vtoriChlen;
                    vtoriChlen = sledvashtChlen;                                         
                }
            }
            else
                {
                    Console.WriteLine("Number is outside of required range of 1 to 50!");
                }
            }
        }
    }

