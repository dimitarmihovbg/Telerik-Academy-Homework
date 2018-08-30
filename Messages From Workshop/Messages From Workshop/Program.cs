using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Messages_From_Workshop
{
    class Program
    {
        public static int Decoding(string linesToDecode)
        {
            List<string> firstInputResult = new List<string>(Regex.Split(linesToDecode, @"(?<=\G.{3})", RegexOptions.Singleline));
            string tempResult = "";
            int result = 0;
            for (int i = 0; i < firstInputResult.Count; i++)
            {
                if (firstInputResult[i] == "cad")
                {
                    tempResult += 0;
                }
                else if (firstInputResult[i] == "xoz")
                {
                    tempResult += 1;
                }
                else if (firstInputResult[i] == "nop")
                {
                    tempResult += 2;
                }
                else if (firstInputResult[i] == "cyk")
                {
                    tempResult += 3;
                }
                else if (firstInputResult[i] == "min")
                {
                    tempResult += 4;
                }
                else if (firstInputResult[i] == "mar")
                {
                    tempResult += 5;
                }
                else if (firstInputResult[i] == "kon")
                {
                    tempResult += 6;
                }
                else if (firstInputResult[i] == "iva")
                {
                    tempResult += 7;
                }
                else if (firstInputResult[i] == "ogi")
                {
                    tempResult += 8;
                }
                else if (firstInputResult[i] == "yan")
                {
                    tempResult += 9;
                }
            }
            result = int.Parse(tempResult);
            return result;
        }
        public static string Enncoding(int totalResultNumber)
        {
            string stringedResultedTotalNumber = totalResultNumber.ToString();
            var stringArrayResult = stringedResultedTotalNumber.Select(x => new string(x, 1)).ToArray();
            string tempResult = "";           
            for (int i = 0; i < stringArrayResult.Length; i++)
            {
                if (stringArrayResult[i] == "0")
                {
                    tempResult += "cad";
                }
                else if (stringArrayResult[i] == "1")
                {
                    tempResult += "xoz";
                }
                else if (stringArrayResult[i] == "nop")
                {
                    tempResult += 2;
                }
                else if (stringArrayResult[i] == "3")
                {
                    tempResult += "cyk";
                }
                else if (stringArrayResult[i] == "4")
                {
                    tempResult += "cyk";
                }
                else if (stringArrayResult[i] == "5")
                {
                    tempResult += "mar";
                }
                else if (stringArrayResult[i] == "6")
                {
                    tempResult += "kon";
                }
                else if (stringArrayResult[i] == "7")
                {
                    tempResult += "iva";
                }
                else if (stringArrayResult[i] == "8")
                {
                    tempResult += "ogi";
                }
                else if (stringArrayResult[i] == "9")
                {
                    tempResult += "yan";
                }
            }            
            return tempResult;
        }

        static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string thirdLine = Console.ReadLine();
            int firstResultNumber = Decoding(firstLine);
            int secondResultNumber = Decoding(thirdLine);
            int totalNumber = 0;          
            if (secondLine == "+")
            {
                totalNumber = firstResultNumber + secondResultNumber;
            }
            else if (secondLine == "-")
            {
                totalNumber = firstResultNumber - secondResultNumber;
            }
            string theRealFinalResult = Enncoding(totalNumber);
            Console.WriteLine(theRealFinalResult);
        }        
    }
}
