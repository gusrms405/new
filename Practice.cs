using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
class Program
{
    static void Main()
    {
        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int left = 0;
        int right = numbers.Length - 1; // left 0 , right 4 배열의 길이(원수의 개수)

        while (left < right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine(string.Join(" ", numbers));

    }
}
