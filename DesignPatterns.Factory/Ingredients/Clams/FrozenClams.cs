using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class FrozenClams:Clams
    {
        public FrozenClams() : base(typeof(FrozenClams).Name) { }
    }
}
