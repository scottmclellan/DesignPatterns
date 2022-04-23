using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class ChocolateBoiler    
    {
         static Lazy<ChocolateBoiler> _chocolateBoiler = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());
        private ChocolateBoiler()
        {

        }

        public static ChocolateBoiler GetInstance()
        {
            return _chocolateBoiler.Value;
        }
    }
}
