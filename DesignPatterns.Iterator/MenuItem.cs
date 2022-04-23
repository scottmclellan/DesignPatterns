using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Description: {Description}");
            sb.AppendLine($"Is Vegetarian?: {IsVegetarian}");
            sb.AppendLine($"Price: {Price:C}");

            return sb.ToString();
        }
    }
}
