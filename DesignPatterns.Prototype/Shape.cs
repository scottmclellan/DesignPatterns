using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public abstract class Shape : IPrototype<Shape>
    {
        private int _x;
        private int _y;

        public Shape()
        { }
        public Shape(Shape shape)
        {
            _x = shape.X;
            _y = shape.Y;
        }


        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public abstract Shape Clone();

        public  override string ToString()
        {
            return $"X: {X}\nY: {Y}";
        }
        
    }
}
