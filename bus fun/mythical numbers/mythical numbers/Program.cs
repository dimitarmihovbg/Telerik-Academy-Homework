using System;
using System.Linq;

namespace mythical_numbers
{
    class Program
    {
        static void Main()
        {
            double Number = int.Parse(Console.ReadLine());
            if (Number > 99 && Number < 1000)
            {
                double[] digits = Number.ToString().ToCharArray().Select(x => (double)Char.GetNumericValue(x)).ToArray();               
                   if ( digits[2] == 0)
                        {
                    double m = digits[0] * digits[1];
                    Console.WriteLine(Math.Round(m, 2).ToString("0.00"));
                }
                   if ( digits[2] <= 5 && digits[2] > 0)
                        {
                    double m2 = (digits[0] * digits[1]) / digits[2];
                    Console.WriteLine(Math.Round(m2,2).ToString("0.00"));
                        }
                   if (digits[2] > 5)
                        {
                    double m3 = (digits[0] + digits[1]) * digits[2];
                      Console.WriteLine(Math.Round(m3, 2).ToString("0.00"));
                        }
            }
        }
    }
}

