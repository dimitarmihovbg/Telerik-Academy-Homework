using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_password
{
    class Program
    {
        public static string PasswordBuilder()
        {
            Random rndGenerator = new Random();
            string capitalLetters = "ABCDEFGHMNOPQRSTUVWJZL";
            string lowerLetters = "abcdefghmnoplkqrtsyuwxz";
            string digits = "1234567890";
            string specialSymbols = "!@#$%&^";

            StringBuilder password = new StringBuilder();


            for (int i = 0; i < 2; i++)
            {
                char symbol = capitalLetters[rndGenerator.Next(0, capitalLetters.Length)];
                int randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);

            }

            for (int i = 0; i < 2; i++)
            {
                char symbol = lowerLetters[rndGenerator.Next(0, lowerLetters.Length)];
                int randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);
            }
            for (int i = 0; i < 1; i++)
            {
                char symbol = digits[rndGenerator.Next(0, digits.Length)];
                int randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);
            }
            for (int i = 0; i < 3; i++)
            {
                char symbol = specialSymbols[rndGenerator.Next(0, specialSymbols.Length)];
                int randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);
            }
            return password.ToString();

        }



        static void Main(string[] args)
        {
            Console.WriteLine(PasswordBuilder());

        }
    }
}
