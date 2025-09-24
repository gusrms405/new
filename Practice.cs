using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("James");
        names.Add("Ari");

        names.Insert(0, "felix");

        Console.WriteLine(names[0]);

        names.RemoveAt(1);
        names.Remove("Ari");

        
    }
}
