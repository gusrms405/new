using System;
using System.Collections;

class Program
{
    static void Main()
    {
        List<int> results = new List<int>();

        for (int i = 1; i <= 1000; i++)
        {
            string s = i.ToString();

            bool only = true;

            foreach (char c in s)
            {
                if (c != '0' && c != '5')
                {
                    only = false;
                    break;
                }
            }

            if (only)
            {
                results.Add(i);
            }
        }
            Console.WriteLine(string.Join(" ", results));

    }
}
