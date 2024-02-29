using System;
class Triangle
{
    protected double A;
    protected double B;
    protected double C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public virtual double Area()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}

class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double a) : base(a, a, a)
    {
        
    }
    public override double Area()
    {
        return (Math.Sqrt(3) / 4) * A * A;
    }
}

class Program
{
    static void Main()
    {
        double a = 5;
        double b = 6;
        double c = 7;
        double d = 5;
        
        Triangle abc = new Triangle(a, b, c);
        Console.WriteLine("Площадь обычного треугольника: " + abc.Area());
        EquilateralTriangle dd = new EquilateralTriangle(d);
        Console.WriteLine("Площадь равностороннего треугольника: " + dd.Area());
    }
}