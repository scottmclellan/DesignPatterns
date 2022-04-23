using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class VeganClams:Clams
    {
        public VeganClams() : base(typeof(VeganClams).Name) { }
    }
}
