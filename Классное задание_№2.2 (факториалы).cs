using System;

class Program
{
    static void Main()
    {
        // Функция для вычисления факториала
        double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        Console.Write("Введите число: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисление ряда Тейлора для sin(x)
        double y = 0;
        for (int n = 0; n < 7; n++)
        {
            int exp = 2 * n + 1;
            double term = Math.Pow(x, exp) / Factorial(exp);
            y += (n % 2 == 0 ? term : -term);  // Чередование знаков
        }

        // Вывод
        Console.WriteLine($"sin({x}) ≈ {y}");
    }
}
