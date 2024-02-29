using System;

namespace Передача_объектов_в_функции
{
    class Function
    {
        public double A { get; }
        public double B { get; }

        public Function(double a, double b)
        {
            A = a;
            B = b;
        }

        public FunctionResult Calculate(Function function)
        {
            if (function.A == Math.PI / 2 || function.A + function.B == Math.PI / 2 || function.A == 3 * Math.PI / 2 || function.A + function.B == 3 * Math.PI / 2)
            {
                throw new ArgumentException("Один из аргументов находится в особой точке, при которой ответ равен 0");
            }

            double f_a = Math.Sin(function.A) * Math.Cos(function.A);
            double g_a = Math.Cos(function.A) - Math.Sin(function.A);
            double f_a_b = Math.Sin(function.A + function.B) * Math.Cos(function.A + function.B);
            double g_a_b = Math.Cos(function.A + function.B) - Math.Sin(function.A + function.B);
            if (g_a == 0 || g_a_b == 0)
            {
                throw new DivideByZeroException("Деление на ноль");
            }

            return new FunctionResult(f_a * g_a * f_a_b * Math.Pow(g_a_b, 2));
        }
    }

    class FunctionResult
    {
        public double Result { get; }

        public FunctionResult(double result)
        {
            Result = result;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Лабораторная работа №10.\nОсновная функция:\nf(x) = sin(x)cos(x), cos(x) - sin(x).\nНайти: f(a)*g(a)*f(a+b)*g^2(a-b)");

            try
            {
                Console.WriteLine("Введите значение a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение b:");
                double b = Convert.ToDouble(Console.ReadLine());

                Function function = new Function(a, b);
                FunctionResult result = function.Calculate(function);
                Console.WriteLine($"Результат вычисления функции: {result.Result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при вычислении функции: {ex.Message}");
            }
        }
    }
}
