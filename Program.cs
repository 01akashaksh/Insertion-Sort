using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original list:");
        PrintList(numbers);

        InsertionSort(numbers);

        Console.WriteLine("Sorted list:");
        PrintList(numbers);
    }

    static void InsertionSort(List<int> list)
    {
        int n = list.Count;
        for (int i = 1; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;

            // Move elements of list[0..i-1], that are greater than key, to one position ahead of their current position
            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j = j - 1;
            }
            list[j + 1] = key;
        }
    }

    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}