using System;
class CombinationsOfSet
{
    static int[] result;
    static int k;
    static int n;
    static void Main()
    {        
        Console.Write("Enter number of elements for combinations: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of combination: ");
        k = int.Parse(Console.ReadLine());
        result = new int[k];       
        Combinations(0, 1);
    }
    static void Combinations(int index, int startValue)
    {
        if (index == k)
        {
            for (int i = 0; i < k; i++)
             Console.Write("{0,3}", result[i]);
            Console.WriteLine();
            return;
        }        
        for (int i = startValue; i <= n; i++)
        {
            result[index] = i;
            Combinations(index + 1, i + 1);
        }
    }
}