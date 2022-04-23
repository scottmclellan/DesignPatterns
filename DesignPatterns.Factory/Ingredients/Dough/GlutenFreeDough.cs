using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class GlutenFreeDough:Dough
    {
        public GlutenFreeDough() : base(typeof(GlutenFreeDough).Name) { }
    }
}
