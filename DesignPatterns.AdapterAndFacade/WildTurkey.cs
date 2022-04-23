using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Flying very short distance.");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble gobble!");
        }

        public void Info()
        {
            Console.WriteLine("I am a Wild Turkey!");
        }
    }
}
