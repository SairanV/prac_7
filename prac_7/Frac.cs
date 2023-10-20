using System;

public class Frac
{
    private int numerator;
    private int denominator;

    public Frac(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static Frac operator +(Frac a, Frac b)
    {
        int commonDenominator = a.denominator * b.denominator;
        int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
        return new Frac(newNumerator, commonDenominator);
    }

    public static Frac operator -(Frac a, Frac b)
    {
        int commonDenominator = a.denominator * b.denominator;
        int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
        return new Frac(newNumerator, commonDenominator);
    }

    public static Frac operator *(Frac a, Frac b)
    {
        int newNumerator = a.numerator * b.numerator;
        int newDenominator = a.denominator * b.denominator;
        return new Frac(newNumerator, newDenominator);
    }

    public static Frac operator /(Frac a, Frac b)
    {
        if (b.numerator == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        int newNumerator = a.numerator * b.denominator;
        int newDenominator = a.denominator * b.numerator;
        return new Frac(newNumerator, newDenominator);
    }

    public static implicit operator double(Frac f)
    {
        return (double)f.numerator / f.denominator;
    }

    public static bool operator ==(Frac a, Frac b)
    {
        return a.numerator == b.numerator && a.denominator == b.denominator;
    }

    public static bool operator !=(Frac a, Frac b)
    {
        return !(a == b);
    }

    public double Evaluate(double x)
    {
        return (double)numerator / denominator;
    }
}
