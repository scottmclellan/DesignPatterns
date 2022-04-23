using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Common;

namespace DesignPatterns.Factory
{
    public abstract class IngredientBase
    {
        private string _name;

        public string Name
        {
            get { return _name.FormatCamelCaseString(); }
            set { _name = value; }
        }

        public IngredientBase(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
