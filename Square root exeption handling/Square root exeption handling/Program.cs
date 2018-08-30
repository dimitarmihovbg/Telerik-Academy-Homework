using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_root_exeption_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();                
                int numberInput = int.Parse(input);
                if (numberInput < 0)
                {
                    throw new FormatException("The number must not be negative");
                }
                Console.WriteLine(Math.Round(Math.Sqrt(numberInput), 3));
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number"); 
            }            
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
