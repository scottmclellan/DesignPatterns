using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ThickCrustDough:Dough
    {
        public ThickCrustDough() : base(typeof(ThickCrustDough).Name) { }
    }
}
