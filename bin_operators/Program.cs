namespace bin_operators;

public class Complex
{
    private double Real { get; set; }
    private double Imaginary { get;  set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }
    
    public static Complex operator -(Complex c1, double scalar)
    {
        return new Complex(c1.Real - scalar, c1.Imaginary);
    }
    
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var a = new Complex(3, 2);
        var b = new Complex(1, 1);
        
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        
        a -= b;
        
        Console.WriteLine($"a -= b: {a}");
    }
}