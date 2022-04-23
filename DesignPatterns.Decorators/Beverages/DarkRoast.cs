using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public  class DarkRoast :  BeverageBase
    {
        public DarkRoast(SizeEnum size):base(size)
        {
            UnitCost = 1.50M;
            Description = "Dark Roast";
        }
    }
}
