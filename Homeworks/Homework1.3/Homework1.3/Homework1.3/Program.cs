using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод коэффициентов a, b и c
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());



        // Вызываем метод для решения уравнения
        SolveEquation(a, b, c);
    }

    static void SolveEquation(double a, double b, double c)
    {
        // Если квадратное уравнение
        if (a != 0)
        {
            // Вычисляем дискриминант
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два решения: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                // Один корень (кратный)
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет одно решение: x = {x}");
            }
            else
            {
                // Нет действительных решений
                Console.WriteLine("Уравнение не имеет действительных решений.");
            }
        }
        // Если линейное уравнение
        else if (b != 0)
        {
            // Вычисляем корень линейного уравнения
            double x = -c / b;
            Console.WriteLine($"Уравнение имеет одно решение: x = {x}");
        }
        // Случай 3: Уравнение не содержит переменных (a == 0 и b == 0)
        else
        {
            // Если c == 0, уравнение имеет бесконечно много решений
            if (c == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечно много решений.");
            }
            else
            {
                // Если c != 0, уравнение не имеет решений
                Console.WriteLine("Уравнение не имеет решений.");
            }
        }
    }
}

