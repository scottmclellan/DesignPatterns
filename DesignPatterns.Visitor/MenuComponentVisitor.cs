using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class MenuComponentVisitor : IMenuComponentVisitor
    {
        public void Visit(Menu menu)
        {
            Console.WriteLine("\n\n\nVisited a menu!");
            menu.Print();
        }

        public void Visit(MenuItem menuItem)
        {
            Console.WriteLine("\n\n\nVisited a menu item!");
            menuItem.Print();
        }
    }
}
