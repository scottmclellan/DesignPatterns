using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class MilestonesDessertMenu : Menu
    {
        public MilestonesDessertMenu() : base("Milestones", "Dessert")
        {
            AddItem("THE COOKIE", "warm double chocolate chunk cookie, French vanilla ice cream, chocolate & caramel sauce, whipped cream, chocolate shavings", true, 9.00M);
            AddItem("WHITE CHOCOLATE CHEESECAKE", "white chocolate, espresso crème anglaise, whipped cream, shaved milk chocolate, fresh strawberry", true, 9.00M);
            AddItem("GANACHE TORTE", "Belgian chocolate ganache, almond crust, fresh strawberry", true, 9.00M);
            AddItem("SUPERBERRY CRISP", "strawberries, raspberries, blackberries, blueberries, apples, brown sugar, ginger, oat flakes, French vanilla ice cream", true, 9.00M);
        }

        private void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            Add(new MenuItem(name, description, isVegetarian, price));
        }
    }
}
