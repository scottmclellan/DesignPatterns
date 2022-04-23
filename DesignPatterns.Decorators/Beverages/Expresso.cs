using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public class Expresso : BeverageBase
    {
        public Expresso(SizeEnum size): base(size)
        {
            UnitCost = 1.10M;
            Description = "Expresso";
        }

    }
}
