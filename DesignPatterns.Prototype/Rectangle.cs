using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle()
        {

        }

        public Rectangle(Rectangle rectangle):base(rectangle)
        {
            _width = rectangle.Width;
            _height = rectangle.Height;
        }

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\nRectangle");
            sb.AppendLine($"Width: {Width}");
            sb.AppendLine($"Height: {Height}");
            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
