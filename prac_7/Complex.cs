using System;

public struct Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        double realPart = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginaryPart = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new Complex(realPart, imaginaryPart);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        if (b.Real == 0 && b.Imaginary == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        double divisor = b.Real * b.Real + b.Imaginary * b.Imaginary;
        double realPart = (a.Real * b.Real + a.Imaginary * b.Imaginary) / divisor;
        double imaginaryPart = (a.Imaginary * b.Real - a.Real * b.Imaginary) / divisor;
        return new Complex(realPart, imaginaryPart);
    }

    public static Complex operator +(double a, Complex b)
    {
        return new Complex(a + b.Real, b.Imaginary);
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imaginary == b.Imaginary;
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        if (Imaginary >= 0)
        {
            return $"{Real} + {Imaginary}i";
        }
        else
        {
            return $"{Real} - {Math.Abs(Imaginary)}i";
        }
    }
}
