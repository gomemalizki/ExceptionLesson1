using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWorld
{
    internal class Rectangle:Shape
    {
        private double width;
        private double length;
        public double Width {
            get { return width; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
            } 
        }
        public double Length
        {
            get { return length; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Rectangle(double width, double length) : base("Rectangle")
        {
            Width = width;
            Length = length;
        }
        public override double Area()
        {
            return Width*Length;
        }
        public override double Perimeter()
        {
            return (Length*2)+(Width*2);
        }
}
