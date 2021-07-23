using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public class Square : Rectangle
    {
        public Square() { }
        public Square(double side) : base(side, side) 
        {
            Title = "Square";
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override double Area()
        {
            return base.Area();
        }       

        public override void Accept(Visitor visitor)
        {
            visitor.VisitSquare(this);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Side: {Length}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }

    }
}
