using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Milk : CondimentDecorator
    {
        public Milk(IBeverage wrappedBeverage) : base(wrappedBeverage)
        {
            base.UnitCost = 0.12M;
            base.Description = "Milk";
        }
    }
}
