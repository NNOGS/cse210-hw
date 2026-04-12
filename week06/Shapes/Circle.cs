using System;

public class Circle : Shape
{
    private double _radius;

    // Initiating A Constructor below
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Initiate method override
    public override double GetArea()
    {
        return Math.PI * _radius;
    }
}