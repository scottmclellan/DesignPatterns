using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Mushroom: Veggie
    {
        public Mushroom() : base(typeof(Mushroom).Name) { }
    }
}
