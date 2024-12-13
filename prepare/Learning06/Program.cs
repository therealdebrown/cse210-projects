using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);

        Rectangle rectangle = new Rectangle("Blue", 5, 3);

        Circle circle = new Circle("Green", 2.5);

        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };
        Console.WriteLine("\nShapes in the List:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
