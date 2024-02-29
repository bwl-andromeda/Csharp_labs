//Создать класс «Треугольник», заданный сторонами.
//Определить производный класс – «Равносторонний треугольник».
//Предусмотреть виртуальную функцию для вычисления площади
//фигуры, продемонстрировать работу функции для треугольников
//со сторонами a, b, c и стороной d, сравнить площади фигур.

interface ITriangle
{
    int A { get; set; }
    int B { get; set; }
    int C { get; set; }
    double CalculateArea();
}

public class Triangle : ITriangle
{
    public Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    public virtual double CalculateArea()
    {
        // Формула Герона
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}

class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(int d) : base(d, d, d)
    {
        
    }
    public override double CalculateArea()
    {
        // Формула площади равностороннего треугольника
        return (Math.Sqrt(3) / 4) * Math.Pow(A, 2);
    }
}

class Program
{
    static void Main()
    {
        Triangle abc = new Triangle(3, 4, 5);
        EquilateralTriangle d = new EquilateralTriangle(6);
        Console.WriteLine($"Площадь треугольника = {abc.CalculateArea()}");
        Console.WriteLine($"Площадь равностороннего треугольника = {d.CalculateArea()}");
    }
}