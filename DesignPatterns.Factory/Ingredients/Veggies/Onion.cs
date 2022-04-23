using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Onion: Veggie
    {
        public Onion() : base(typeof(Onion).Name) { }
    }
}
