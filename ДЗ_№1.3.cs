﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите коэффициенты для уравнения ax^2 + bx + c = 0:");

        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Обработка различных случаев
        if (a == 0 && b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечно много решений :D");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений :(");
            }
        }
        else if (a == 0)
        {
            // Линейное уравнение bx + c = 0
            double x = -c / b;
            Console.WriteLine($"Линейное уравнение. Решение: x = {x:F4}");
        }
        else
        {
            // Решение квадратного уравнения
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант: D = {discriminant:F4}");

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1:F4}, x2 = {x2:F4}");
            }
            else if (discriminant == 0)
            {
                // Один корень
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {x:F4}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений :(");
            }
        }
    }
}
