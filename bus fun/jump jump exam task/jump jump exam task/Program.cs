using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jump_jump_exam_task
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int currentPosition = 0;
            string[] jumpInstructions = Regex.Split(input, string.Empty);
            currentPosition = int.Parse(jumpInstructions[0]);
            int counter = 0;
            if (currentPosition == 2 || currentPosition == 4 || currentPosition == 6 || currentPosition == 8)
            {
               int P = int.Parse(jumpInstructions[0]);
                counter = counter + P;
                currentPosition = int.Parse(jumpInstructions[counter]);
               if (currentPosition > 9 || currentPosition < 0)
               {
                   Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                    break;                 
               }
            if (currentPosition == 1 || currentPosition == 3 || currentPosition == 5 || currentPosition == 7 || currentPosition == 9)
                {
                    int P2 = int.Parse(jumpInstructions[0]);
                    counter = counter - P2;
                    currentPosition = int.Parse(jumpInstructions[counter]);
                    if (currentPosition > 9 || currentPosition < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                        break;
                    }
                }
                if (currentPosition == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", currentPosition);
                    break;
                }
                if (currentPosition == ^)
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", currentPosition);
                    break;
                }






                //for (int i = 0; i < jumpInstructions.Length; i++)
                //{
                //    if (currentPosition > 9 | currentPosition < 0)
                //    {
                //        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //        break;
                //    }
                //    //currentPosition += int.Parse(jumpInstructions[i]);

                //    if (jumpInstructions[i] == "2" | jumpInstructions[i] == "4" | jumpInstructions[i] == "6" | jumpInstructions[i] == "8")
                //        {
                //        int P = int.Parse(jumpInstructions[i]);
                //        currentPosition += P;
                //            if (currentPosition > 9 | currentPosition < 0)
                //            {
                //            Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //            break;
                //            }
                //        }                    
                //     if (jumpInstructions[i] == "1" | jumpInstructions[i] == "3" | jumpInstructions[i] == "5" | jumpInstructions[i] == "7" | jumpInstructions[i] == "9")
                //        {
                //        int P2 = int.Parse(jumpInstructions[i]);
                //        currentPosition -= P2;
                //        if (currentPosition > 9 | currentPosition < 0)
                //        {
                //            Console.WriteLine("Fell off the dancefloor at {0}!", i);
                //            break;
                //        }
                //        }
                //    if (jumpInstructions[i] == "0")
                //        {
                //        Console.WriteLine("Too drunk to go on after {0}!", i);
                //        break;
                //        }
                //    if (jumpInstructions[i] == "^")
                //        {
                //        Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                //        break;
                //        }










                //if (currentPosition == 2 || currentPosition == 4 || currentPosition == 6 || currentPosition == 8)
                //{
                //    int P = int.Parse(jumpInstructions[i]);
                //    currentPosition += P;
                //    if (currentPosition > 9 || currentPosition < 0)
                //    {
                //        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //        break;
                //    }
                //    if (currentPosition == 1 || currentPosition == 3 || currentPosition == 5 || currentPosition == 7 || currentPosition == 9)
                //    {
                //        currentPosition -= P;
                //        if (currentPosition > 9 | currentPosition < 0)
                //        {
                //            Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //            break;
                //        }
                //    }





                //    if (jumpInstructions[i] == "2" | jumpInstructions[0] == "4" | jumpInstructions[0] == "6" | jumpInstructions[0] == "8")
                //{
                //    int P = int.Parse(jumpInstructions[i]);
                //    currentPosition += P;
                //    if (currentPosition > 9 | currentPosition < 0)
                //    {
                //        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //        break;
                //    }
                //}
                //if (jumpInstructions[i] == "1" | jumpInstructions[0] == "3" | jumpInstructions[0] == "5" | jumpInstructions[0] == "7" | jumpInstructions[0] == "9")
                //{
                //    int P = int.Parse(jumpInstructions[i]);
                //    currentPosition -= P;
                //    if (currentPosition > 9 | currentPosition < 0)
                //    {
                //        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition);
                //        break;
                //    }
                //}
                //if (jumpInstructions[i] == "0")
                //{
                //    Console.WriteLine("Too drunk to go on after {0}!", currentPosition);
                //    break;
                //}
                //if (jumpInstructions[i] == "^")
                //{
                //    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", currentPosition);
                //    break;
                //}
            }

        }
        }
 }


