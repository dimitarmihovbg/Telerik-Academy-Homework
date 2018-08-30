using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_sorted_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file1 = File.ReadAllLines(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Save sorted names\source.txt");
            Array.Sort(file1);
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\Save sorted names\result.txt");
            foreach (var item in file1)
            {
                file.WriteLine(item);
            }          
            file.Close();
        }
    }
}
