using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class Circle : Shape
    {
        private int _diameter;

        public Circle() { }

        public Circle(Circle circle) : base(circle)
        {
            _diameter = circle.Diameter;
        }

        public int Diameter { get => _diameter; set => _diameter = value; }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\nCircle");
            sb.AppendLine($"Diameter: {Diameter}");
            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
