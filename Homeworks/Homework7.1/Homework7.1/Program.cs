using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");

        try 
        {
            string input = Console.ReadLine();
            int number = ConvertToInt(input);
            Console.WriteLine($"Вы ввели число: {number}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число слишком большое или слишком маленькое");
        }
        catch (FormatException) 
        {
            Console.WriteLine("Ошибка: введено не число.");
        }

    }

    static int ConvertToInt(string input)
    {
        return int.Parse(input);
    }
}