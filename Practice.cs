using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
class Program
{
    static void Main()
    {
        

        List<string> names = new List<string>();

        names.Add("젤다");
        names.Add("리쿵");
        names.Add("가논");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        
    }
}
