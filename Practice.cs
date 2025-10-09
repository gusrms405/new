using System;
using System.Collections;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main()
    {
        int[][] a = new int[5][];
        List<int> b = new List<int>();

        a[0] = new int[] { 1, 2, 3, 4 };
        a[1] = new int[] { 5, 8, 11, 41 };
        a[2] = new int[] { 6, 1, 4, 4 };
        a[3] = new int[] { 1, 2, 3, 4 };
        a[4] = new int[] { 1, 2, 3, 4 };

        foreach (int[] numbers in a)
        {
            foreach (int number in numbers)
            {
                if (number > 10)
                {
                    b.Add(number);
                }
            }
        }

        foreach (int n in b)
        {
            Console.WriteLine(n);
        }
    }
}
