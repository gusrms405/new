using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        long n = 600851475143;
        long factor = 2;

        while (n > 1)
        {
            if (n % factor == 0)
            {
                n = n / factor;
            }

            else
            {
                factor++;
            }
        }
        Console.WriteLine(factor);
    }
}