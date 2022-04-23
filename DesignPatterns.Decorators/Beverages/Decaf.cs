using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public  class Decaf: BeverageBase
    {
        public Decaf(SizeEnum size): base(size)
        {
            UnitCost = 1.35M;
            Description = "Decaf";
        }
    }
}
