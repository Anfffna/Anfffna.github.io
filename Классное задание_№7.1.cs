﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");

        try // блок, в котором рассматриваются исключения
        {
            string input = Console.ReadLine();
            int number = ConvertToInt(input);
            Console.WriteLine($"Вы ввели число: {number}");
        }
        catch (FormatException) // если возникла ошибка
        {
            Console.WriteLine("Ошибка: введено не число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.");
        }
    }

    static int ConvertToInt(string input)
    {
        return int.Parse(input); // строку в целое число
    }
}
