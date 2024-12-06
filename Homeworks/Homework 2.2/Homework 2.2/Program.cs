using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число для вычисления (факториал/фибоначчи): ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Ошибка: введите неотрицательное целое число.");
        }

        Console.Write("Выберите метод (1 - факториал, 2 - фибоначчи): ");
        int choice = int.Parse(Console.ReadLine());

        Stopwatch stopwatch = new Stopwatch();

        if (choice == 1)
        {
            // Факториал
            stopwatch.Start();
            BigInteger factorialRec = FactorialRecursive(n);
            stopwatch.Stop();
            Console.WriteLine($"Рекурсивно: {n}! = {factorialRec}, время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            stopwatch.Restart();
            BigInteger factorialIter = FactorialIterative(n);
            stopwatch.Stop();
            Console.WriteLine($"Итеративно: {n}! = {factorialIter}, время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
        else if (choice == 2)
        {
            // Число Фибоначчи
            stopwatch.Start();
            BigInteger fibonacciRec = FibonacciRecursive(n);
            stopwatch.Stop();
            Console.WriteLine($"Рекурсивно: F({n}) = {fibonacciRec}, время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            stopwatch.Restart();
            BigInteger fibonacciIter = FibonacciIterative(n);
            stopwatch.Stop();
            Console.WriteLine($"Итеративно: F({n}) = {fibonacciIter}, время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
    }

    // Рекурсивное вычисление факториала
    static BigInteger FactorialRecursive(int n)
    {
        if (n == 0) return 1;
        return n * FactorialRecursive(n - 1);
    }

    // Итеративное вычисление факториала
    static BigInteger FactorialIterative(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // Рекурсивное вычисление чисел Фибоначчи
    static BigInteger FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Итеративное вычисление чисел Фибоначчи
    static BigInteger FibonacciIterative(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        BigInteger a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
}