using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class TeaNoCondiments : Tea
    {
        protected override bool ShouldAddCondiments()
        {
            return false;
        }

    }
}
