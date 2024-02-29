using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Лабораторная работа #13:\n");
        Console.WriteLine("Задание: Найти произведение четырех комплексных чисел.\n");

        Console.WriteLine("Введите комплексные числа (a, b, c, d): ");
        double[] complexNumbers = new double[8];
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Введите компонент {i + 1}: ");
            complexNumbers[i] = double.Parse(Console.ReadLine());
        }
        double result = MultiplyComplexNumbers(complexNumbers);
        Console.WriteLine($"Результат умножения комплексных чисел: {result}");
        Console.ReadKey();
    }

    static double MultiplyComplexNumbers(params double[] numbers)
    {
        if (numbers.Length != 8)
        {
            throw new ArgumentException("Должно быть передано ровно восемь компонент для четырех комплексных чисел.");
        }

        double resultReal = numbers[0] * numbers[2] - numbers[1] * numbers[3]; 
        double resultImaginary = numbers[0] * numbers[3] + numbers[2] * numbers[1]; // Мнимая часть

        resultReal *= numbers[4] * numbers[6] - numbers[5] * numbers[7];
        resultImaginary *= numbers[4] * numbers[7] + numbers[6] * numbers[5];

        return resultReal + resultImaginary;
    }
}
