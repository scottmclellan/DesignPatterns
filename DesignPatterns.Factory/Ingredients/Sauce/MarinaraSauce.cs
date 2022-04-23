using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class MarinaraSauce: Sauce
    {
        public MarinaraSauce() : base(typeof(MarinaraSauce).Name) { }
    }
}
