using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public class Triangle : Shape, IPointy
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public int Points { get; set; } = 3;

        public Triangle() { }
        public Triangle(double sideA, double sideB, double sideC)
        {
            Title = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double area = Math.Sqrt(semiPerimeter 
                                        * (semiPerimeter - SideA)
                                        * (semiPerimeter - SideB)
                                        * (semiPerimeter - SideC));
            return area;
        }        

        public override void Accept(Visitor visitor)
        {
            visitor.VisitTriangle(this);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Sides: {SideA}, {SideB}, {SideC}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }
    }
}
