using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public interface IMenu
    {
        int MenuType { get; }
        IEnumerator<MenuItem> GetIterator();
    }

    public class MenuTypes
    {
        public const int Breakfast = 1;
        public const int Lunch = 2;
        public const int Dinner = 4;
    }

}
