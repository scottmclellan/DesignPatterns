using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class SlicedPepperoni:Pepperoni
    {
        public SlicedPepperoni() : base(typeof(SlicedPepperoni).Name) { }
    }
}
