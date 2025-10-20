using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWorld
{
    internal class Shape
    {
        public string Name { get; init; }
        public Shape(string name) {
            Name = name;
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter() {
            return 0;
        }
}
