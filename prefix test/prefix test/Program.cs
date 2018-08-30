using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefix_test
{
    class Program
    {
        static void Main(string[] args)
        {
               string text = File.ReadAllText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\prefix test\wtf.txt");
                string[] arr = text.Split(' ');
                string[] resultedArr = new string[arr.Length];
                string searchTerm = "test";
                for (int i = 0; i < arr.Length; i++)
                {                 
                    if(arr[i].Contains(searchTerm))
                    {
                        resultedArr[i] = null;
                    }
                    else
                    {
                        resultedArr[i] = arr[i];
                    }
                }
                string result = "";
                for (int i = 0; i < resultedArr.Length; i++)
                {
                    if (resultedArr[i] != null)
                    {
                    result += resultedArr[i] + " ";
                    }
                }    
                File.WriteAllText(@"C:\Users\mitac\Desktop\Visual Studio Files\C# ADVANCED COURSE\New folder\prefix test\wtf.txt", result);
        }
    }
}

