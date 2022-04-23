using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage wrappedBeverage) : base(wrappedBeverage)
        {
            base.UnitCost = 0.25M;
            base.Description = "Mocha";
        }
    }
}
