using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class Forest
    {
        private List<Tree> _trees = new List<Tree>();

        public void PlantTree(int x, int y, string name, string colour, string texture)
        {
            var type = TreeFactory.GetTreeType(name, colour, texture);
            var tree = new Tree(x, y, type);
            _trees.Add(tree);
        }

        public void Draw()
        {
            foreach(var tree in _trees)
            {
                tree.Draw();
            }
        }
    }
}
