using DesignPatterns.Behaviours.Duck;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class DuckAdapter : ITurkey
    {
        private IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }   

        public void Fly()
        {
            _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Info()
        {
            _duck.About();
            Console.WriteLine("Adapted to a Turkey.");
        }            
    }
}
