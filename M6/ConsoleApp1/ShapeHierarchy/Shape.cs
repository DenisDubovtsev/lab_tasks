using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    public abstract class Shape
    {
        public string Title { get; set; }

        public virtual double Perimeter() => 0;
        public virtual double Area() => 0;

        public abstract void Accept(Visitor visitor);

        public virtual void Info() { }
    }
}
