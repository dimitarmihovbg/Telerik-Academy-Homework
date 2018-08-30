using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileContents
{
    class Program
    {
        static void Main()
        {
            string alpha = Console.ReadLine();
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(alpha));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Dude put some path on the road, yo");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This path is too wrong for you. AVOID DRUGS i said!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You have no permission to be there, or there is nothing of interest for you (White Collar advice).");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid path. WTF is wrong with you man?");
            }
            catch (Exception)
            {
                Console.WriteLine("Damn, something went wrong (like your birth)");
            }            
        }
    }
}
