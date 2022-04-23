using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ThinCrustDough:Dough
    {
        public ThinCrustDough() : base(typeof(ThinCrustDough).Name) { }
    }
}
