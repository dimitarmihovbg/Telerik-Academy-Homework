using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Date_in_Bulgarian
{
    class Program
    {

        static void Main()
        {
            string inputDate = Console.ReadLine();
            string[] inputArray = inputDate.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                if ( inputArray[i]
            }
            DateTime dateAndTime = DateTime.ParseExact(inputDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime outputDate = dateAndTime.AddHours(6).AddMinutes(30);
            //DateTime.Now.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("bg-BG"));
            Console.WriteLine("{0} и днес сме: {1}", outputDate, outputDate.ToString("dddd", new CultureInfo("bg-BG")));


          


        }
    }
}
