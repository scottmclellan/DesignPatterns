using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class OrganicTomatoSauce : Sauce
    {
        public OrganicTomatoSauce() : base(typeof(OrganicTomatoSauce).Name) { }
    }
}
