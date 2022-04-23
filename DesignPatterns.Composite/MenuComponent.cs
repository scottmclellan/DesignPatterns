using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {

        }

        public virtual void Remove(MenuComponent menuComponent)
        {

        }

        public virtual MenuComponent GetChild(int index)
        {
            return null;
        }

        public virtual string Name
        {
            get
            {
                return string.Empty;
            }
        }

        public virtual string Description
        {
            get
            {
                return string.Empty;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return 0.00M;
            }
        }

        public virtual bool IsVegetarian
        {
            get
            {
                return false;
            }
        }

        public virtual void Print()
        {

        }

    }
}
