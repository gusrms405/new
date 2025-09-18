using System;
class Program
{
    static void Main()
    {
        int a = 0;
        int b;

        for (b = 1; b < 1000; b++)
        {
            if (b % 3 == 0 || b % 5 == 0)
            {
                a += b;
            }

        }
        Console.WriteLine(a);
    }
}