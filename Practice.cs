using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        Console.WriteLine($"{number}");

    }
}