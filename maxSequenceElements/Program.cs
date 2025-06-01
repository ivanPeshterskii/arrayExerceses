using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bestLength = 1;
        int bestStartIndex = 0;

        int currentLength = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStartIndex = i - bestLength + 1;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        for (int i = bestStartIndex; i < bestStartIndex + bestLength; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}