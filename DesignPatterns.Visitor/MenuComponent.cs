using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
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

        public virtual int GetChildCount()
        {
            return 0;
        }

        public abstract void AcceptVisitor(IMenuComponentVisitor visitor);

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
