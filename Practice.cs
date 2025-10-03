using System;
using System.Collections;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main()
    {
        Dictionary<string, int> monster = new Dictionary<string, int>();

        monster.Add("슬라임", 10);
        monster.Add("고블린", 20);
        monster.Add("프라임", 45);

        int sum = 0;
        int count = 0;

        foreach (var pair in monster)
        {
            sum += pair.Value;
            count++;
        }

        double average = (double)sum / count;

        Console.WriteLine("평균 경험치: " + average);
    }
}
