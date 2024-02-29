class Program
{
    static void Main()
    {
        Console.WriteLine("Лабороторная работа №12.\nЗадача: использовать ref,out параметры\nСоставить программу вычисления суммы факториалов всех\nчетных чисел от m до n.");
        int m, n;
        Console.WriteLine("Введите начальное значение (m):");
        int.TryParse(Console.ReadLine(), out m);
        Console.WriteLine("Введите конечное значение (n):");
        int.TryParse(Console.ReadLine(), out n);

        var sum = 0;
        CalculateFactorialSum(m, n, ref sum);
        Console.WriteLine($"Сумма факториалов всех четных чисел от {m} до {n} равна {sum}");
    }

    static void CalculateFactorialSum(int start, int end, ref int result)
    {
        for (var i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                result += Factorial(i);
            }
        }
    }

    static int Factorial(int num)
    {
        var factorial = 1;
        for (var i = 2; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
