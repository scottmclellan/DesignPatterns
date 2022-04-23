using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class DinerMenu : Menu
    {
        public DinerMenu() : base("Diner", "Lunch")
        {
            AddItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomatoe on whole wheat", true, 2.99M);
            AddItem("BLT", "(Fakin) Bacon with lettuce & tomatoe on whole wheat", false, 2.99M);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29M);
            AddItem("Hot dog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05M);
        }

        private void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            Add(new MenuItem(name, description, isVegetarian, price));
        }
    }
}
