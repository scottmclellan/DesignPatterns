using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }

        public TreeType Type { get; private set; }
        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public void Draw()
        {
            Type.Draw(X, Y);
        }
    }
}
