using System;

public class Fraction
{
    // Private attributes(Encapsulation)
    private int _numerator;
    private int _denominator;

    // Default Constructor (sets fraction to 1/1) 
    // with no parameter.
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;


        // Prevent division by zero
        if (denominator == 0)
        {
            _denominator = 1;
        }
        else
        {
            _denominator = denominator;
        }
    }
    // Getter and Setter for Numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    // Getter and Setter for Denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            _denominator = value;
        }
    }

    // Method to return as string(e.g, "3/4")
    public String GetFractionString()
    {
        return $"{_numerator} / {_denominator}";
    }

    // Method to return double decimal value(e.g,0.75)
    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
