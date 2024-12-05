using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "11.1.txt";

        // Создаем или перезаписываем файл
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // заголовок
            writer.WriteLine("x    sin(x)");

            // Вычисляем и записываем значения sin(x) для x от 0 до 1 с шагом 0,1
            for (double x = 0.0; x <= 1.0; x += 0.1)
            {
                // Записываем значение x и sin(x) в файл с форматированием
                writer.WriteLine($"{x:F1}  {Math.Sin(x):F4}");
            }
        }

        Console.WriteLine($"Таблица значений sin(x) успешно записана в файл {filePath}.");
    }
}


