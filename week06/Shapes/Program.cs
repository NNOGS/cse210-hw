using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("blue", 6, 4);
        Circle circle = new Circle("Green", 2);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());


        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());


        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 3, 5));
        shapes.Add(new Circle("Green", 2));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}