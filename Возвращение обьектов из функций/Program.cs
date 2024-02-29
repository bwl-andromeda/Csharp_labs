using System;

class Program
{
    class CalculationResult
    {
        public double X { get; }
        public double Result { get; }

        public CalculationResult(double x, double result)
        {
            X = x;
            Result = result;
        }
    }

    static void Main()
    {
        Console.WriteLine("Лабораторная работа №11\nВозвращение объектов из функции.");
        Console.WriteLine("\nПротабулируйте функции.\nОтрезок и шаг вводятся с клавиатуры:\nЗадача: sh(x) - x + 1");
        Console.Write("Введите начало отрезка: ");
        var start = double.Parse(Console.ReadLine());

        Console.Write("Введите конец отрезка: ");
        var end = double.Parse(Console.ReadLine());

        Console.Write("Введите шаг: ");
        var step = double.Parse(Console.ReadLine());

        Console.WriteLine(" x    |sh(x) - x + 1");
        Console.WriteLine("------------------");

        for (var x = start; x <= end; x += step)
        {
            CalculationResult result = Calculate(x);
            Console.WriteLine($"{result.X,-6} | {result.Result,-10}");
        }
    }

    static CalculationResult Calculate(double x)
    {
        var shX = (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2;
        var result = shX - x + 1;
        return new CalculationResult(x, result);
    }
}
