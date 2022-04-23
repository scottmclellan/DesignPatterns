using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class PancakeHouseMenu : Menu
    {
        public PancakeHouseMenu() : base("Pancake House", "Breakfast")
        {
            AddItem("K&B's Pancake Breakfast", "Pancakes with scambled eggs and toast", true, 2.99M);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99M);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49M);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59M);
        }

        private void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            Add(new MenuItem(name, description, isVegetarian, price));
        }
    }
}
