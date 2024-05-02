using System;

class Triangle<T>
    where T : struct, IComparable<T>, IFormattable
{
    protected T a;
    protected T b;
    protected T c;

    public Triangle(T sideA, T sideB, T sideC)
    {
        a = sideA;
        b = sideB;
        c = sideC;
    }

    public virtual double CalculateArea()
    {
        double sideA = Convert.ToDouble(a);
        double sideB = Convert.ToDouble(b);
        double sideC = Convert.ToDouble(c);
        double s = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        return area;
    }
}

class EquilateralTriangle<T> : Triangle<T>
    where T : struct, IComparable<T>, IFormattable
{
    private T d;

    public EquilateralTriangle(T side) : base(side, side, side)
    {
        d = side;
    }

    public override double CalculateArea()
    {
        double side = Convert.ToDouble(d);
        return (Math.Sqrt(3) / 4) * side * side;
    }
}

class Program
{
    static void Main()
    {
        Triangle<double> triangle = new Triangle<double>(3, 4, 5);
        double areaTriangle = triangle.CalculateArea();
        Console.WriteLine($"Площадь треугольника со сторонами a=3, b=4, c=5: {areaTriangle}");
        EquilateralTriangle<double> equilateralTriangle = new EquilateralTriangle<double>(5);
        double areaEquilateralTriangle = equilateralTriangle.CalculateArea();
        Console.WriteLine($"Площадь равностороннего треугольника со стороной d=5: {areaEquilateralTriangle}");
        Console.WriteLine($"Разница между площадями треугольников: {Math.Abs(areaTriangle - areaEquilateralTriangle)}");
        Console.ReadKey();
    }
}
