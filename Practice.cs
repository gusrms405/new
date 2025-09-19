using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        int a = 1, b = 2, sum = 0;

        while (a <= 4000000)
        {
            if (a % 2 == 0)
            {
                sum += a;
            }

            int next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine(sum);
    }
}