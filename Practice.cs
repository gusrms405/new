using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
class Program
{
    static void Main()
    {
        int i = 1, n = 10;
        int sum = 0;
        while (i <= n)
        {
            Console.WriteLine(i);
            sum += i;
            i = i + 2;
        }
        Console.WriteLine();
        Console.WriteLine(sum);
        
    }
}
