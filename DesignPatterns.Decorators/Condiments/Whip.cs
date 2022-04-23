using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage wrappedBeverage) : base(wrappedBeverage)
        {
            base.UnitCost = 0.15M;
            base.Description = "Whip";
        }
    }
}
