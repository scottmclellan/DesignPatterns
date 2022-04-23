using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ReggianoCheese:Cheese
    {
        public ReggianoCheese():base(typeof(ReggianoCheese).Name)
        { }
    }
}
