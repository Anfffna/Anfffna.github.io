﻿using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 2, 4, 6, 5, 7, 8, 10, 9};

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++) // n проходов
            for (int j = 0; j < n - 1; j++) // Проход по массиву
                if (arr[j] > arr[j + 1]) // Сравнение
                {
                    // Обмен местами
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}

