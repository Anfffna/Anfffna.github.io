class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;
        HashSet<int> uniqueNumbers = new HashSet<int>(); // Для хранения уникальных чисел

        Console.WriteLine("Введите 10 различных чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (!uniqueNumbers.Add(input)) // Проверка на уникальность
            {
                Console.WriteLine("Введены одинаковые числа. Попробуйте снова.");
                i--; // Уменьшаем индекс, чтобы повторно запросить число
                continue;
            }

            // Обновление max и secondMax
            if (input > max)
            {
                secondMax = max;
                max = input;
            }
            else if (input > secondMax)
            {
                secondMax = input;
            }
        }

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Следующее по величине число: {secondMax}");
    }
}