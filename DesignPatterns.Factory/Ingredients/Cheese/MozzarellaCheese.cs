using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class MozzarellaCheese:Cheese
    {
        public MozzarellaCheese():base(typeof(MozzarellaCheese).Name)
        { }
    }
}
