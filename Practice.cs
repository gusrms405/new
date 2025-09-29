using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
class Program
{
    static void Main()
    {
        int[][] numbers = new int[3][];
        numbers[0] = new int[] { 3, 7, 12, 20 };
        numbers[1] = new int[] { 0, 5, 15 };
        numbers[2] = new int[] { 8, 9, 14, 18, 2 };

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                if (numbers[i][j] > 10)
                    Console.WriteLine(numbers[i][j]);
            }


        }
        

    }
}
