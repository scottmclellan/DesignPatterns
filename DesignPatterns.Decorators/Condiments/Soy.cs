using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(IBeverage wrappedBeverage) : base(wrappedBeverage)
        {
            base.UnitCost = 0.40M;
            base.Description = "Soy";
        }
    }
}
