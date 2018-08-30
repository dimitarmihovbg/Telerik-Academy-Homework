using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_text_files
{
    class Program
    {
        static void Main()
        {
            string[] file1 = File.ReadAllLines(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Concatenate text files\meat.txt");
            string[] file2 = File.ReadAllLines(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Concatenate text files\potato.txt");

            using (StreamWriter writer = File.CreateText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Concatenate text files\output5.txt"))
            {
                int counterGeneral = 0;
                int counterOne = 0;
                int counterTwo = 0;
                int  lineNum = 1;
                while (counterGeneral < file1.Length || counterGeneral < file2.Length)
                {
                    while(counterOne < file1.Length)
                    {
                        writer.WriteLine(lineNum + " " + file1[counterOne]);
                        counterOne++;
                        lineNum++;
                    }
                    while (counterTwo < file2.Length)
                    {
                        writer.WriteLine(lineNum + " " + file2[counterTwo]);
                        counterTwo++;
                        lineNum++;
                    }
                    counterGeneral++;
                }
            }
        }
    }
}

