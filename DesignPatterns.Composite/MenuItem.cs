using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override decimal Price { get; }

        public override void Print()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Description: {Description}");
            sb.AppendLine($"Is Vegetarian?: {IsVegetarian}");
            sb.AppendLine($"Price: {Price:C}");

            Console.WriteLine(sb.ToString());
        }
    }
}
