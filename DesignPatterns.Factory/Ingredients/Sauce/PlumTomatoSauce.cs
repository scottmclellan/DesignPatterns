using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class PlumTomatoSauce: Sauce
    {
        public PlumTomatoSauce() : base(typeof(PlumTomatoSauce).Name) { }
    }
}
