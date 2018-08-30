using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Save_sorted_names
{
    class Program
    {
        private static void ReplaceTextInFile(string originalFile, string outputFile, string searchTerm, string replaceTerm)
        {
            string tempLineValue;
            int counter = 0;
            using (FileStream inputStream = File.OpenRead(originalFile))
            {
                using (StreamReader inputReader = new StreamReader(inputStream))
                {
                    using (StreamWriter outputWriter = File.AppendText(outputFile))
                    {
                        while (null != (tempLineValue = inputReader.ReadLine()))
                        {
                            counter++;
                            if (counter % 2 != 0)
                            {
                                outputWriter.WriteLine();
                            }
                        }
                    }
                }
            }

            //string input = "test, and test but not testing.  But yes to test";
            //string pattern = @"\btest\b";
            //string replace = "text";
            //string result = 
            //Console.WriteLine(result);


        }


        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Replace Sub Strings\source.txt");
            text = text.Replace("start", "finish");
            File.WriteAllText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Replace Sub Strings\source.txt", text);
        }
    }
}


