using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects_UNOFICIAL_train
{
    class Program
    {
        public static string Repeat(int count)
        {
        StringBuilder result = new StringBuilder();

            while (count > 0)
            {                
                result.Append("*");
                count--;
            }
            return result.ToString();
        }


    static void Main()
        {
            //BigBankAccount pesho = new BigBankAccount();
            //Console.WriteLine();
            //pesho.passiveIncome = 2000;
            //Console.ReadLine();
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("wow");


            int repeatTimes = 4000000;
            Console.WriteLine(Repeat(repeatTimes));
            //string result = "";

            //while (repeatTimes > 0)
            //{
            //    result += "*";
            //    repeatTimes--;
            //}
            //Console.WriteLine(result);
            


        }
    }
    class BigBankAccount
    {
        public static int babati = 5;

        public int sum = 10000;

        public int passiveIncome = 3000;

        public static int mamatimetod()
        {
            int result = 0;

            return result;

        }

    }

}
