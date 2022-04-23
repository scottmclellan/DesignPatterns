using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public  class MediumRoast : BeverageBase
    {
        public MediumRoast(SizeEnum size) : base(size)
        {
            UnitCost = 1.45M;
            Description = "Medium Roast";
        }
    }
}


