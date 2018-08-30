using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_lines
{
    class Program
    {
        static void Main()
        {
            try
            {
                using (var fs = File.OpenRead(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Odd lines\Wazup.txt"))
                using (var sr = new StreamReader(fs, Encoding.UTF8, true))
                {
                    String line;                    
                    int lineNumber = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNumber++;

                        if (lineNumber % 2 != 0)
                        {
                            Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        }
                    }
                    sr.Close();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("WTF man");
            }
        }
    }
}
