using System;

namespace bus_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            int[] arrayBus = new int[C];
            int counter = 1;
            for (int m = 0; m < C; m++)
            {
                Console.WriteLine("Please Enter Speed of Bus #{0}: ", m);
                arrayBus[m] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k+1 < C; k++)
            {
                if (arrayBus[k] < arrayBus[k+1])
                {
                    arrayBus[k + 1] = arrayBus[k];
                }
                else
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
