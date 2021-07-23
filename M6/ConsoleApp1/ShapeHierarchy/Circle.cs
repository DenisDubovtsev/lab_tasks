using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double radius)
        {
            Title = "Circle";
            Radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
                
        public override void Accept(Visitor visitor)
        {
            visitor.VisitCircle(this);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }
    }
}
