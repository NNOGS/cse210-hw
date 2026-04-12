using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    //Initiating the Constructor below
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Initiating a Method Override Below
    public override double GetArea()
    {
        return _length * _width;
    }
}