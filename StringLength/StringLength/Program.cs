﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length < 20);
            {
                for (int i = input.Length; i < 20; i++)
                {
                    input = input + "*";
                }
            }
            Console.WriteLine(input);
        }
    }
}
