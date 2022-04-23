using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class VeganPepperoni:Pepperoni
    {
        public VeganPepperoni() : base(typeof(VeganPepperoni).Name) { }
    }
}
