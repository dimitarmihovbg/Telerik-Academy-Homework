using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineOOP
{
    public class IPhone4S
    {
        private static int screenSize = 400;
        private static int price = 900;
        private static string model = "Iphone4S";
        private string owner = "DefaultOwner";

        public IPhone4S(string owner)
        {
            this.owner = owner;
        }
        public void PrintIphone4S()
        {
            Console.WriteLine("Screen Size is: " + screenSize);
            Console.WriteLine("Price is: " + price);
            Console.WriteLine("Model is: " + model);
            Console.WriteLine("Owner is" + owner);
        }


    }
}
