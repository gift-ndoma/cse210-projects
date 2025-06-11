using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 12));
        shapes.Add(new Circle("Red", 10));
        shapes.Add(new Rectangle("Orange", 10, 12));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea ());
        }
    }
}