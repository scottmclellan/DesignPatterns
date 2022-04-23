using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class GreeenPepper: Veggie
    {
        public GreeenPepper() : base(typeof(GreeenPepper).Name) { }
    }
}
