using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите коэффициенты a, b и c для уравнения ax^2 + bx + c = 0");

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveQuadraticEquation(a, b, c);
    }

    static void SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение.");
            return;
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("У уравнения два решения: x1 = {0}, x2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("У уравнения одно решение: x = {0}", x);
        }
        else
        {
            Console.WriteLine("У уравнения нет действительных решений.");
        }
    }
}