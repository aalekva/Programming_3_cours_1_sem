using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число копеек: ");
        int cop = Convert.ToInt32(Console.ReadLine());


        string res = NumberToWords(cop);
        Console.WriteLine(res);
    }

    static string NumberToWords(int number)
    {
        if (number == 0)
        {
            Console.Write("Ноль копеек");
        }

        string[] ed = { "", "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] des = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        string[] teen = { "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

        string res = "";

        if (number >= 20)
        {
            res += des[number / 10];
            number %= 10;
            if (number > 0)
                res += " " + ed[number];
        }
        else if (number >= 11 && number <= 19)
        {
            res += teen[number - 11];
        }
        else
        {
            res += ed[number];
        }

        // Обработка окончания
        if (number == 11|| number == 12 || number == 13 || number == 14 || number == 15
            || number == 16 || number == 17 || number == 18 || number == 19)
        {
            res += " копеек";
        }
        else if (number % 10 == 0)
        {
            res += " копеек";
        }
        else if (number%10 == 1) {
            res += " копейка";
                }
        else if (number % 10 == 2 || number % 10 == 3 || number % 10 == 4)
        {
            res += " копейки";
        }
        else if (number % 10 == 5 || number % 10 == 6 || number % 10 == 7 || number % 10 == 8 || number % 10 == 9)
        {
            res += " копеек";
        }

        return res.Trim();
    }
}

