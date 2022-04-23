using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class CondimentDecorator : BeverageBase
    {
        private IBeverage _wrappedBeverage;
        public CondimentDecorator(IBeverage wrappedBeverage) : base(wrappedBeverage.Size)
        {
            _wrappedBeverage = wrappedBeverage;
        }
       
        public override string Description { get => string.Join(',', base.Description, _wrappedBeverage.Description); set => base.Description = value; }

        public override decimal TotalCost { get => base.TotalCost + _wrappedBeverage.TotalCost; }
    }
}
