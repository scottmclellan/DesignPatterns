using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private MenuItem[] _items;
        private int _position;

        public DinerMenuIterator(DinerMenu menu) : this(menu.GetMenuItems())
        {

        }

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _items = menuItems;
        }

        public MenuItem Current
        {
            get
            {
                var item = _items[_position];
                _position++;
                return item;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
                return false;

            return true;
        }


        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
