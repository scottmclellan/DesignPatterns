using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Sugar : CondimentDecorator
    {
        public Sugar(IBeverage wrappedBeverage) : base(wrappedBeverage)
        {
            base.UnitCost = 0.05M;
            base.Description = "Sugar";
        }
    }
}
