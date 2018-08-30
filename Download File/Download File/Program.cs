using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Download_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the full URL:");
            string path = Console.ReadLine();
            string[] resultedArray = path.Split('/');
            string nameOfFile = resultedArray[resultedArray.Length - 1]; 
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(path, nameOfFile);
                }
            }
            catch(OutOfMemoryException)
            {
                Console.WriteLine("No More memory, baby!");
            }
            catch (ApplicationException)
            {
                Console.WriteLine("Wow...");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Do NOT hack the matrix, bro");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Bad object... try using something smaller for that hole, alright?");
            }         
            catch (Exception)
            {
                Console.WriteLine("Something Went Wrong Nigga");
            }            
        }
    }
}
