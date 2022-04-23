using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class NonDairyCheese : Cheese
    {
        public NonDairyCheese() : base(typeof(NonDairyCheese).Name) { }
    }
}
