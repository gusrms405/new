using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("몇 단을 출력할까요?");

        int a = int.Parse(Console.ReadLine());

        for (int b = 1; b <= 9; b++)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }


    }
}