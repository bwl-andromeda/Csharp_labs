using System;

class Одномерный
{
    public static void Main()
    {
        // Дан целочисленный массив из n элементов. Найти в нем
        // убывающую подпоследовательность максимальной длины
        Console.WriteLine("Лабороторная работа №6 \nЗадание:\nДан целочисленный массив из n элементов. Найти в нем\r\nубывающую подпоследовательность максимальной длины");
        Console.WriteLine("Введите размер массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива [{i}]:");
            array[i] = (Convert.ToInt32(Console.ReadLine()));
        }
        int count,result;
        count = 0;
        result = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                count += 1;
                if (result < count)
                {
                    result = count;
                }
                else
                {
                    count = 0;
                }
            }
        }
        Console.WriteLine($"Ответ: {result}");
    }
}