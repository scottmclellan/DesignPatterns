using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class PancakeHouseMenu :IMenu
    {
        private List<MenuItem> _menuItems;

        public int MenuType => 1;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scambled eggs and toast", true, 2.99M);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99M);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49M);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59M);
        }

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(menuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return _menuItems.GetEnumerator();
        }
    }
}
