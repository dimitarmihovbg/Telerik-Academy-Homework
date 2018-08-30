using System;

namespace bus_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            if (D < 1000000 && D > 1)
            {
                int counter = 0;                            
                while (D > 0)
                {
                    counter++;
                    if (counter < 10)
                    {
                        D -= 1;
                    }
                    else if (counter < 100)
                    {
                        D -= 2;
                    }
                    else if (counter < 1000)
                    {
                        D -= 3;
                    }
                    else if (counter < 10000)
                    {
                        D -= 4;
                    }
                    else if (counter < 100000)
                    {
                        D -= 5;
                    }
                    else if (counter < 1000000)
                    {
                        D -= 6;
                    }
                   
                }
                Console.WriteLine(counter);
                
            }
            

            //int[] arrayBus = new int[C];
            //int counter = 1;
            //for (int m = 0; m < C; m++)
            //{
            //    Console.WriteLine("Please Enter Speed of Bus #{0}: ", m);
            //    arrayBus[m] = int.Parse(Console.ReadLine());
            //}
            //for (int k = 0; k + 1 < C; k++)
            //{
            //    if (arrayBus[k] < arrayBus[k + 1])
            //    {
            //        arrayBus[k + 1] = arrayBus[k];
            //    }
            //    else
            //    {
            //        counter++;
            //    }

            //}
            //Console.WriteLine(counter);
        }
    }
}
