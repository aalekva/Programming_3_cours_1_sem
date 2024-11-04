using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива, разделенные запятой:");
        string? input = Console.ReadLine();

        //Проверка на пустой ввод
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ввод не может быть пустым.");
            return; 
        }

        //Преобразуем строку ввода в массив чисел
        string[] inputArray = input.Split(',');
        int[] array = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = Convert.ToInt32(inputArray[i].Trim());
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    //Обмен элементов, если они в неправильном порядке
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
