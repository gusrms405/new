using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        Console.WriteLine("첫 번째 숫자를 입력하세요");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("두 번째 숫자를 입력하세요");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("세 번째 숫자를 입력하세요");
        string c = Console.ReadLine();

        if (c == +)
            int A = a + b;
            Console.WriteLine($"{a} {c} {b} = {A}");
        

    }
}