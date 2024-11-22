using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("f.txt"))
        {
            writer.WriteLine("x  sin(x)");
            for (double x = 0.0; x <= 1.0; x += 0.1)
            {
                double sinX = Math.Sin(x);
                writer.WriteLine($"{x:F1}  {sinX:F4}");
            }
        }

        Console.WriteLine("Таблица значений успешно записана в файл f.txt.");
    }
}

