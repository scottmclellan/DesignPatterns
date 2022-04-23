using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Iterator
{
    public class MilestonesMenu : IMenu
    {
        private Dictionary<string, MenuItem> _menuItems;

        public int MenuType => 7;

        public MilestonesMenu()
        {
            _menuItems = new Dictionary<string, MenuItem>();

            AddItem("SPINACH & ARTICHOKE DIP", "Italian style cheeses, fresh cut salsa, tortilla chips", true, 13.00M);
            AddItem("CALIFORNIA SPRING SALAD", "goat cheese, strawberries, avocado, red onion, spiced pecans, honey mustard vinaigrette", true, 15.00M);
            AddItem("1989 BURGER", "ground chuck & brisket, smoked bacon, cheddar, burger sauce, egg bun", false, 19.00M);
            AddItem("CHIMICHURRI SEA BASS", "pan seared Asian sea bass, chimichurri butter, tricoloured quinoa & rice pilaf, seasonal vegetables", false, 28.00M);
        }

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(menuItem.Name, menuItem);
        }

        public Dictionary<string, MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return _menuItems.Select(x => x.Value).GetEnumerator();
        }
    }
}