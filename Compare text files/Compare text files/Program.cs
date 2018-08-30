using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_text_files
{
    class Program
    {
        static void Main()
        {
            string[] file1 = File.ReadAllLines(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Compare text files\lol.txt");
            string[] file2 = File.ReadAllLines(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Compare text files\wtf.txt");
            
            int counter = 0;
            for (int i = 0; i < file1.Length; i++)
            {
                if (file1[i] == file2[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            
                       
                //int lineNum = 0;
                //while (lineNum < file1.Length || lineNum < file2.Length)
                //{
                //    if (lineNum < file1.Length)
                //        writer.WriteLine(file1[lineNum]);
                //    if (lineNum < file2.Length)
                //        writer.WriteLine(file2[lineNum]);
                //    lineNum++;
                //}
            
        }
    }
}
