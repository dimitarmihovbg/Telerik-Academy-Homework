﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            charArray.ToString();
            Console.WriteLine(charArray);
        }
    }
}
