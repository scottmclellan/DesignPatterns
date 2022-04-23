using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public  class HouseBlend :  BeverageBase
    {
        public HouseBlend(SizeEnum size) : base(size)
        {
            UnitCost = 1.25M;
            Description = "House Blend";
        }
    }
}
