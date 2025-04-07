using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("blue", 2);
        Rectangle rectangle = new Rectangle("red", 6, 1.5);
        Circle circle = new Circle("green", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color : {shape.GetColor()}");
            Console.WriteLine($"Area : {shape.GetArea()}");
        }


    }
}