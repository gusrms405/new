using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        // string text = " Hello World ";

        // text.Contains("World"); 특정 문자열 포함 여부(bool 반환)
                                // true
        // text.Replace("World", "C#"); 문자열 치환

        // text.Split(' ') 공백 기준으로 나누기 (배열 반환)
        
        // string text = " Hello World ";

    // 1) 특정 문자열 포함 여부
    bool hasWorld = text.Contains("World");
    Console.WriteLine(hasWorld);  // true

    // 2) 문자열 치환
    string replaced = text.Replace("World", "C#");
    Console.WriteLine(replaced);  // " Hello C# "

    // 3) 공백 기준으로 나누기
    string[] parts = text.Split(' ');
    foreach (string part in parts)
    {
        Console.WriteLine($"[{part}]");

    }
}