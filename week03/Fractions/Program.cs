using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Using default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine("Default Fraction:");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine();

        // Using whole number constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine("Whole Number as Fraction:");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine();

        // Using numerator/denominator constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine("Custom Fraction:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine();

        // Testing setters
        f3.SetNumerator(1);
        f3.SetDenominator(3);
        Console.WriteLine("Updated Fraction:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}