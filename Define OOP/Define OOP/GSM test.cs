using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineOOP
{
    public class GSMtest
    {
        public static object[] gsmArray = new object[3];

        private void CreateGSM()
        {          

            MobilePhone gsmTwo = new MobilePhone("3310", "nokia", 300,
                "fat Vonko", "Lol",
                300, 30, 500,
                2300);

            MobilePhone gsmThree = new MobilePhone("3320", "nokia", 300,
            "non-fat Vonko", "Lol",
            300, 30, 500,
            2300);

            MobilePhone gsmFour = new MobilePhone("3330", "nokia", 300,
            "vonko cannot be unfat (error 404)", "Lol",
            300, 30, 500,
            2300);

            gsmArray[0] = gsmTwo;
            gsmArray[1] = gsmThree;
            gsmArray[2] = gsmFour;
        }
        public static void PrintGSMtest()
        {
            foreach (GSMtest gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());
            }
        }
    }
    
}
