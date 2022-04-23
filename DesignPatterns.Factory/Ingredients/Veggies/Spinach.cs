using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Spinach: Veggie
    {
        public Spinach() : base(typeof(Spinach).Name) { }
    }
}
