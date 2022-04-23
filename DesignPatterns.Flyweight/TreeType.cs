using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class TreeType
    {
        public TreeType(string name, string colour, string texture)
        {
            Name = name;
            Colour = colour;
            Texture = texture;
        }

        public string Name { get; set; }
        public string Colour { get; set; }
        public string Texture { get; set; }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Colour: {Colour}");
            Console.WriteLine($"Texture: {Texture}");
            Console.WriteLine($"Location (X:{x} Y:{y})");
        }
    }
}
