﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

     
        int targetSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == targetSum)
                {
                    Console.WriteLine($"{arr[i]} {arr[j]}");
                }
            }
        }
    }
}
