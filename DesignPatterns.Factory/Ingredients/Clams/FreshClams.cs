using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class FreshClams:Clams
    {
        public FreshClams() : base(typeof(FreshClams).Name) { }
    }
}
