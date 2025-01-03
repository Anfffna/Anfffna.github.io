﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine($"Простые числа до {max}:");

        for (int i = 2; i <= max; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
