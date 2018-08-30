using System;


namespace Play_Cards
{
    class Program
    {
        static void Main()
        {
                string s = Console.ReadLine();
                 if (s.Length <= 5)
              {
                if ((s == "2") || (s == "4") || (s == "5")
                     || (s == "6") || (s == "7") || (s == "8") || (s == "9") || (s == "10") 
                                   || (s == "Q") || (s == "J") || (s == "K") || (s == "A"))
                {
                    Console.WriteLine("yes"+" "+s);
                }
                else
                {
                    Console.WriteLine("no" + " " + s);
                }
              }
                 else
            {
                Console.WriteLine("Please - next time input string up to 5 characters!");
            }
          }
        }
    }
