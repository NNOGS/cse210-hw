using System;

public class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter - allowing color change(following Encapsulation principle)
    public string GetColor()
    {
        return _color;
    }

    // Setter - allowing color change(following Encapsulation principle)
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual Method Initiation below
    public virtual double GetArea()
    {
        return 0;
    }
}