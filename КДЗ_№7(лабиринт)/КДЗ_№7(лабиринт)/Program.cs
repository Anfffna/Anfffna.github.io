using System;

class Program
{
    static void Main(string[] args)
    {
        const int width = 20;
        const int height = 10;

        char[,] maze = GenerateMaze(width, height);
        bool[,] visible = new bool[width, height];
        int playerX = 1, playerY = 1;

        while (true)
        {
            Console.Clear();
            DisplayMaze(maze, visible, playerX, playerY);
            Console.WriteLine("Используйте клавиши W, A, S, D для движения. Нажмите Q для выхода.");

            char input = Console.ReadKey(true).KeyChar;
            if (input == 'q') break;

            int newX = playerX, newY = playerY;
            switch (input)
            {
                case 'w': newY--; break;
                case 'a': newX--; break;
                case 's': newY++; break;
                case 'd': newX++; break;
                default: continue;
            }

            if (maze[newX, newY] != '#') // Проверка на стену
            {
                playerX = newX;
                playerY = newY;
                visible[newX, newY] = true; // Открываем новую клетку

                if (maze[newX, newY] == 'X') // Выход найден
                {
                    Console.Clear();
                    DisplayMaze(maze, visible, playerX, playerY);
                    Console.WriteLine("Мои поздравления!! Вы нашли выход! ;)");
                    break;
                }
            }
        }
    }

    static char[,] GenerateMaze(int width, int height)
    {
        char[,] maze = new char[width, height];
        Random random = new Random();

        // Заполняем лабиринт стенами
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                maze[x, y] = '#';
            }
        }

        // Алгоритм случайной генерации лабиринта
        void CarvePath(int x, int y)
        {
            maze[x, y] = ' '; // Путь
            int[] directions = { 0, 1, 2, 3 }; // 0: Вверх, 1: Вправо, 2: Вниз, 3: Влево
            ShuffleArray(directions, random);

            foreach (var dir in directions)
            {
                int nx = x, ny = y;
                switch (dir)
                {
                    case 0: nx = x; ny = y - 2; break; // Вверх
                    case 1: nx = x + 2; ny = y; break; // Вправо
                    case 2: nx = x; ny = y + 2; break; // Вниз
                    case 3: nx = x - 2; ny = y; break; // Влево
                }

                if (nx > 0 && nx < width - 1 && ny > 0 && ny < height - 1 && maze[nx, ny] == '#')
                {
                    maze[nx, ny] = ' ';
                    maze[(x + nx) / 2, (y + ny) / 2] = ' '; // Разрушаем стену между клетками
                    CarvePath(nx, ny);
                }
            }
        }

        CarvePath(1, 1); // Начинаем с позиции (1,1)

        // Гарантируем доступность выхода
        maze[width - 2, height - 2] = ' ';
        maze[width - 3, height - 2] = ' ';
        maze[width - 2, height - 3] = ' ';
        maze[width - 2, height - 2] = 'X'; // Устанавливаем выход

        // Делаем стартовую позицию игрока доступной
        maze[1, 1] = ' ';
        maze[2, 1] = ' ';
        maze[1, 2] = ' ';

        return maze;
    }

    static void ShuffleArray(int[] array, Random random)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    static void DisplayMaze(char[,] maze, bool[,] visible, int playerX, int playerY)
    {
        for (int y = 0; y < maze.GetLength(1); y++)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                if (x == playerX && y == playerY)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем красный цвет
                    Console.Write('R'); // Игрок
                    Console.ResetColor(); // Сбрасываем цвет
                }
                else if (visible[x, y])
                {
                    Console.Write(maze[x, y]); // Открытые клетки
                }
                else
                {
                    Console.Write('#'); // Закрытые клетки
                }
            }
            Console.WriteLine();
        }
    }
}


