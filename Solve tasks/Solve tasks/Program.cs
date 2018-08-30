using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_tasks
{
    class Program
    {

        public static void One()
        {                   
                Console.WriteLine("Please enter the positive number:");
                decimal Number = decimal.Parse(Console.ReadLine());
            if (Number >= 0)
            {
                string babati = Number.ToString();
                char[] Nums = babati.ToCharArray();
                Array.Reverse(Nums);
                foreach (var item in Nums)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nachi batka... trqq si polojitelno nastroen! Opita pak! ,)");
            }               
            
        }
        public static void Two()
        {
            Console.WriteLine("Please enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b: ");
            double b = double.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select One of the following option:");
            Console.WriteLine("1. Type \"One\" in order to reverse the digits of a Number");
            Console.WriteLine("2. Type \"Two\" in order to solve the equation a*x + b = 0");
            string input = Console.ReadLine();
            if (input == "One")
            {               
                One();
                
            }
            else if (input == "Two")
            {
                Two();
            }
        }
    }
}
