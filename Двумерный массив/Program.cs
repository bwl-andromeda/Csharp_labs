using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите элемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < rows; i++)
        {
            int sumPositive = 0;
            int productNegative = 1;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    sumPositive += matrix[i, j];
                }
                else if (matrix[i, j] < 0)
                {
                    productNegative *= matrix[i, j];
                }
            }
            Console.WriteLine($"Сумма положительных элементов в строке {i + 1}: {sumPositive}");
            Console.WriteLine($"Произведение отрицательных элементов в строке {i + 1}: {productNegative}");
        }
    }
}
