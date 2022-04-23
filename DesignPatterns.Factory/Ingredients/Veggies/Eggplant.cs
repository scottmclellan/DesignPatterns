using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Eggplant: Veggie
    {
        public Eggplant() : base(typeof(Eggplant).Name) { }
    }
}
