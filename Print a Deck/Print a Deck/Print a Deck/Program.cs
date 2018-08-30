using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Deck
{
    class Program
    {
        static void Main()
        {
            string sign = Console.ReadLine();
            int length = 0;

            switch (sign)
            {
                case "J":
                    length = 11;
                        break;
                case "Q":
                    length = 12;
                    break;
                case "K":
                    length = 13;
                    break;
                case "A":
                    length = 14;
                    break;
                default:
                    length = int.Parse(sign);
                    break;                 
             }
            for (int i=2; i <= 14; i++)
            {
                sign = string.Empty;
                switch (i)
                {
                    case 11:
                        sign = "J";
                            break;
                    case 12:
                        sign = "Q";
                            break;
                    case 13:
                        sign = "K";
                            break;
                    case 14:
                        sign = "A";
                            break;
                    default:
                        sign = string.Empty + i;
                        break;
                }
                string output = "{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds";
                Console.WriteLine(output, sign);
            }







        }
    }
}
