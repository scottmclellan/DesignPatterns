using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class MilestonesMenu : Menu
    {
        public MilestonesMenu() : base("Milestones", "Diner")
        {
            AddMenuItem("SPINACH & ARTICHOKE DIP", "Italian style cheeses, fresh cut salsa, tortilla chips", true, 13.00M);
            AddMenuItem("CALIFORNIA SPRING SALAD", "goat cheese, strawberries, avocado, red onion, spiced pecans, honey mustard vinaigrette", true, 15.00M);
            AddMenuItem("1989 BURGER", "ground chuck & brisket, smoked bacon, cheddar, burger sauce, egg bun", false, 19.00M);
            AddMenuItem("CHIMICHURRI SEA BASS", "pan seared Asian sea bass, chimichurri butter, tricoloured quinoa & rice pilaf, seasonal vegetables", false, 28.00M);

            AddMenu(new MilestonesDessertMenu());
        }

        private void AddMenu(MilestonesDessertMenu milestonesDessertMenu)
        {
            Add(milestonesDessertMenu);
        }

        private void AddMenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Add(new MenuItem(name, description, isVegetarian, price));
        }
    }
}
