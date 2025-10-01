using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
class Program
{
    static void Main()
    {
        bool[,] flags = new bool[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i > j)
                    flags[i, j] = true;
                else
                    flags[i, j] = false;
            }
        }
        for (int i = 0; i < flags.GetLength(0); i++)   // 행
        {
            for (int j = 0; j < flags.GetLength(1); j++) // 열
            {
                Console.Write(flags[i, j] + "\t"); // \t는 탭 간격
            }
            Console.WriteLine(); // 행이 끝나면 줄바꿈
        }
    }
}
