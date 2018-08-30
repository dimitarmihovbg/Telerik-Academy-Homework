using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_leap_year
{
    class Program
    {      
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            int startYear = 1752;
            int result = 0;
            if (year < startYear)            
            {
                result = year - startYear;
            }
           else
            {
                result = startYear - year;
            }
            if (result % 4 == 0)
            {
                Console.WriteLine("leap");
            }
            else
            {
                Console.WriteLine("common");
            }
        }
    }
}
