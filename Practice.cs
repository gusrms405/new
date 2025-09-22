using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        Console.WriteLine("1. 게임 시작\n2. 옵션\n3. 종료 ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("게임 시작");
                break;

            case 2:
                Console.WriteLine("옵션 선택됨");
                break;

            case 3:
                Console.WriteLine("게임 종료");
                break;

            default:
                Console.WriteLine("잘못된 입력");
                break;  
        }


    }
}