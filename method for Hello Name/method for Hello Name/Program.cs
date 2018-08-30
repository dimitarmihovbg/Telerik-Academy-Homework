using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_for_Hello_Name
{
    class Program
    {

        public static void HelloName(string name)
        {
            Console.WriteLine("Hello"+name);            
        }


        static void Main()
        {
            string S = Console.ReadLine();
            HelloName(S);
            Console.WriteLine();
        }
    }
}
