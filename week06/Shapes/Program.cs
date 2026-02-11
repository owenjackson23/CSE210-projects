using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 5),
            new Rectangle("Green", 2.5, 3),
            new Circle("Blue", 4.7)
        };

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"\nColor: {color}\nArea: {area:F2}\n");
        }
    }
}