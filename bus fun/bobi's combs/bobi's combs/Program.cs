using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobi_s_combs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Bobby's Head: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Number of Combs Bobby has thrown his parents' money for: ");
            int NumberOfCombs = int.Parse(Console.ReadLine());
            //int K = int.Parse(Console.ReadLine());
            int[] Combs = new int[NumberOfCombs];
            for (int m = 0; m < NumberOfCombs; m++)
            {
                Console.WriteLine("Please enter Size of Comb{0}: ", m);
                Combs[m] = int.Parse(Console.ReadLine());
            }



            int N2 = N;
            List<int> binary = new List<int>();
            while (N2 != 0)
            {
                if (N2 % 2 == 0)
                {
                    binary.Add(0);
                }
                else
                {
                    binary.Add(1);
                }
                N2 = N2 / 2;
            }          
            binary.Reverse();

            string maikaTi = Convert.ToString(NumberOfCombs, 2);
            Console.WriteLine(NumberOfCombs);



            //for (int j = 0; j < binary.Count; j++)
            //{
            //    Console.Write(binary[j] + " ");
            //}



        }
    }
    }

  
