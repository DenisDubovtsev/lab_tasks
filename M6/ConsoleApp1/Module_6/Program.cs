using System;
using PolynomialLib;

namespace Module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_2();

            Polynomial p1 = new Polynomial(2, 1);
            Polynomial p2 = new Polynomial(4, 3, 2, 1);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 * p2);
            Console.WriteLine((p1 * p2).Calculate(1.2d));
            Console.ReadLine();

        }

        public static void Task_2()
        {
            ShapeCollection shapes = new ShapeCollection();

            shapes.Add(new Circle(1));
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Rectangle(2.2, 3.5));
            shapes.Add(new Square(1.2));

            shapes.Accept(new VisitorGetInfo());
        }
    }
}
