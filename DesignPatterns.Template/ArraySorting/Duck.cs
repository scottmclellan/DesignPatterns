using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DesignPatterns.Template
{
    public class Duck : IComparable<Duck>
    {
        private int _weight;

        public int Weight
        {
            get { return _weight; }          
        }

        private string _name;     

        public string Name
        {
            get { return _name; }           
        }

        public Duck(int weight, string name)
        {
            _weight = weight;
            _name = name;
        }

        public override string ToString()
        {
            return $"{Name} weighs {Weight}lbs.";
        }

        public int CompareTo([AllowNull] Duck other)
        {
            if (this.Weight < other.Weight) return -1;

            if (this.Weight == other.Weight) return 0;

            if (this.Weight > other.Weight) return 1;

            return 0;
        }
    }
}
