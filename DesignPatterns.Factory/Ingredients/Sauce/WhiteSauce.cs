using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class WhiteSauce: Sauce
    {
        public WhiteSauce() : base(typeof(WhiteSauce).Name) { }
    }
}
