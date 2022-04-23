using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class TreeFactory
    {
        private static List<TreeType> _treeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string colour, string texture)
        {
            TreeType treeType; 
            
            treeType = _treeTypes.Find(x => x.Name == name && x.Colour == colour && x.Texture == texture);

            if (treeType == null)
            {
                treeType = new TreeType(name, colour, texture);
                _treeTypes.Add(treeType);
            }

            return treeType;

        }
    }
}
