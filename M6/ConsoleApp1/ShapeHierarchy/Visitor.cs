using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public abstract class Visitor
    {
        public abstract void VisitTriangle(Triangle tr);
        public abstract void VisitCircle(Circle cr);
        public abstract void VisitRectangle(Rectangle rt);
        public abstract void VisitSquare(Square sq);
    }


    public class VisitorGetInfo : Visitor
    {
        public override void VisitTriangle(Triangle tr)
        {
            tr.GetInfo();
        }
        public override void VisitCircle(Circle cr)
        {
            cr.GetInfo();
        }
        public override void VisitRectangle(Rectangle rt)
        {
            rt.GetInfo();
        }
        public override void VisitSquare(Square sq)
        {
            sq.GetInfo();
        }        
    }

    public class ShapeCollection
    {
        List<Shape> shapes = new List<Shape>();
        public void Add(Shape element)
        {
            shapes.Add(element);
        }
        public void Remove(Shape element)
        {
            shapes.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (var element in shapes)
            {
                element.Accept(visitor);
            }                
        }
    }
}
