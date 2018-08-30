using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();            
            DateTime dt = DateTime.Parse(date);
            string dateTwo = Console.ReadLine();
            DateTime dtTwo = DateTime.Parse(dateTwo);         
            TimeSpan result = dtTwo - dt;
            double days = result.TotalDays;
            Console.WriteLine("Distance: "+days+" days");
        }
    }
}

