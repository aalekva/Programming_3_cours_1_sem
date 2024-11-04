using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 различных чисел:");

        //Ввод чисел пользователем
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Переменных для хранения наибольших чисел
        int max = int.MinValue;
        int secondMax = int.MinValue;

        //Поиск наибольшего и второго по величине числа
        foreach (int number in numbers)
        {
            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number > secondMax && number < max)
            {
                secondMax = number;
            }
        }

        //Проверка на случай, если ввели все одинаковые числа
        if (secondMax == int.MinValue)
        {
            Console.WriteLine("Следующего по величине числа нет (все числа могут быть одинаковыми).");
        }
        else
        {
            Console.WriteLine($"Наибольшее число: {max}");
            Console.WriteLine($"Следующее по величине число: {secondMax}");
        }
    }
}
