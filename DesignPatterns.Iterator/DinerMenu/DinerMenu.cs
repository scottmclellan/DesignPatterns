using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class DinerMenu: IMenu
    {
        private const int _MAX_MENU_SIZE = 6;
        private MenuItem[] _menuItems;
        private int _numberOfMenuItems = 0;

        public int MenuType => 6;

        public DinerMenu()
        {
            _menuItems = new MenuItem[_MAX_MENU_SIZE];

            AddItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomatoe on whole wheat", true, 2.99M);
            AddItem("BLT", "(Fakin) Bacon with lettuce & tomatoe on whole wheat", false, 2.99M);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29M);
            AddItem("Hot dog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05M);
        }

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);

            if (_numberOfMenuItems == _MAX_MENU_SIZE)
                Console.WriteLine($"Sorry no more room for more menu items. (Max of {_MAX_MENU_SIZE})");
            else
            {
                _menuItems[_numberOfMenuItems] = menuItem;
                _numberOfMenuItems++;
            }

        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return new DinerMenuIterator(this);
        }

    }
}
