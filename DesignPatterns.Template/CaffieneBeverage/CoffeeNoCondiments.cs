using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class CoffeeNoCondiments : Coffee
    {

        protected override bool ShouldAddCondiments()
        {
            return false;
        }

    }
}
