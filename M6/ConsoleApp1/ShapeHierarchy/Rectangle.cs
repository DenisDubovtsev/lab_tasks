using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public class Rectangle : Shape, IPointy
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Points { get; set; } = 4;

        public Rectangle() { }
        public Rectangle(double length, double width)
        {
            Title = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
        public override double Area()
        {
            return Length * Width;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitRectangle(this);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Length: {Length}, width: {Width}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }

    }
}
