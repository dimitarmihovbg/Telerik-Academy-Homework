using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(random.Next(100,200));
            }
        }
    }
}
