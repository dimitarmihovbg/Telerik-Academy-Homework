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

            using (StreamWriter writer = File.CreateText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Concatenate text files\output.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length || lineNum < file2.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }
        }
    }
}

