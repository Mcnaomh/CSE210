using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square firstSquare = new Square();
        firstSquare.SetColor("Blue");
        firstSquare.SetSide(8);

        Rectangle firstRectangle = new Rectangle();
        firstRectangle.SetColor("Red");
        firstRectangle.SetLength(4);
        firstRectangle.SetWidth(2);

        Circle firstCircle = new Circle();
        firstCircle.SetColor("Black");
        firstCircle.SetRadius(2.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(firstSquare);
        shapes.Add(firstRectangle);
        shapes.Add(firstCircle);

        foreach (Shape shp in shapes)
        {
            Console.WriteLine(shp.GetColor());
            Console.WriteLine(shp.GetArea());
        }
    }
}