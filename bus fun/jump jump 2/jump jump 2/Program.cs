using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jump_jump_2
{
    class Program
    {
        static void Main()
        {
            string jumpInstructions = Console.ReadLine();    
                       
            int P3 = 0;
            
            while (P3 != 1999)
            {
                char currentPosition = jumpInstructions[P3];
                int currentPositionNumber = currentPosition - '0';

                if (P3 > 9 || P3 < 0)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", P3);
                    break;
                }

                if (currentPositionNumber == 2 || currentPositionNumber == 4 || currentPositionNumber == 6 || currentPositionNumber == 8)
                {                    
                    P3 = currentPositionNumber;
                    if (P3 > 9 || P3 < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", P3);
                        break;
                    }
                 if (currentPositionNumber == 1 || currentPositionNumber == 3 || currentPositionNumber == 5 || currentPositionNumber == 7 || currentPositionNumber == 9)
                    {                        
                        P3 -= currentPositionNumber;
                        if (P3 > 9 || P3 < 0)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", P3);
                            break;
                        }
                    }
                    if (currentPositionNumber == 0)
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", P3);
                        break;
                    }
                    if (currentPosition == '^')
                    {
                        Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", P3);
                        break;
                    }
                }
            }
        }
    }
}
