using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int steps = CountStepsToReachOne(n);
        Console.WriteLine($"Количество замен для приведения числа {n} к 1: {steps}");
    }

    static int CountStepsToReachOne(int n)
    {
        int steps = 0;

        //Если число изначально 1
        if (n <= 1)
        {
            return 0; //Никаких замен не требуется
        }

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2; //Если число четное, делим на 2
            }
            else
            {
                n = 3 * n + 1; //Если число нечетное, умножаем на 3 и прибавляем 1
            }
            steps++; //Увеличиваем счетчик замен
        }

        return steps;
    }
}

