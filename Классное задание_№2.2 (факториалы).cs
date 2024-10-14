using System;
using System.Diagnostics;

class Program
{
    // Итеративный подсчет факториала
    static long FactorialIterative(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    // Рекурсивный подсчет факториала
    static long FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * FactorialRecursive(n - 1);
    }

    // Итеративный подсчет Фибоначчи
    static long FibonacciIterative(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        long prev1 = 1, prev2 = 0;
        for (int i = 2; i <= n; i++)
        {
            long current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }
        return prev1;
    }

    // Рекурсивный подсчет Фибоначчи
    static long FibonacciRecursive(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static void Main()
    {
        int maxN = 35;  // Верхняя граница для проверки
        var stopwatch = new Stopwatch();

        Console.WriteLine("Сравнение времени выполнения для факториала:");
        for (int i = 1; i <= maxN; i++)
        {
            // Время для итеративного метода факториала
            stopwatch.Restart();
            FactorialIterative(i);
            stopwatch.Stop();
            long iterativeTime = stopwatch.ElapsedTicks;

            // Время для рекурсивного метода факториала
            stopwatch.Restart();
            FactorialRecursive(i);
            stopwatch.Stop();
            long recursiveTime = stopwatch.ElapsedTicks;

            Console.WriteLine($"n = {i}: Итеративный = {iterativeTime} тиков, Рекурсивный = {recursiveTime} тиков");
        }

        Console.WriteLine("\nСравнение времени выполнения для Фибоначчи:");
        for (int i = 1; i <= maxN; i++)
        {
            // Время для итеративного метода Фибоначчи
            stopwatch.Restart();
            FibonacciIterative(i);
            stopwatch.Stop();
            long iterativeTime = stopwatch.ElapsedTicks;

            // Время для рекурсивного метода Фибоначчи
            stopwatch.Restart();
            FibonacciRecursive(i);
            stopwatch.Stop();
            long recursiveTime = stopwatch.ElapsedTicks;

            Console.WriteLine($"n = {i}: Итеративный = {iterativeTime} тиков, Рекурсивный = {recursiveTime} тиков");
        }
    }
}
