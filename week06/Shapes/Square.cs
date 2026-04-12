using System;

public class Square : Shape
{
    private double _side;

    // Constructor Initiation
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Method Initiation Override
    public override double GetArea()
    {
        return _side * _side;
    }
}