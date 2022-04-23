using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class Waitress
    {
        private IMenu[] _menues;      

        public Waitress(params IMenu[] menues)
        {
            _menues = menues;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Printing Full Menu...");
            Console.WriteLine("");

            foreach (var menu in _menues)
            {
                PrintMenu(menu);
            }
        }

        private void PrintMenu(int menuType)
        {
            foreach (var menu in _menues.Where(x => (x.MenuType & menuType) == menuType))
            {
                PrintMenu(menu);
            }
        }

        public void PrintBreakfastMenu()
        {
            Console.WriteLine("Printing Breakfast Menu...");
            Console.WriteLine("");

            PrintMenu(MenuTypes.Breakfast);
        }       

        public void PrintLunchMenu()
        {
            Console.WriteLine("Printing Lunch Menu...");
            Console.WriteLine("");

            PrintMenu(MenuTypes.Lunch);
        }

        public void PrintDinnerMenu()
        {
            Console.WriteLine("Printing Dinner Menu...");
            Console.WriteLine("");

            PrintMenu(MenuTypes.Dinner);
        }

        private void PrintMenu(IMenu menu)
        {
            var iterator = menu.GetIterator();

            while (iterator.MoveNext())
                Console.WriteLine(iterator.Current.ToString());
        }


        public bool IsVegetarian(string name)
        {
            return false;
        }
    }
}
