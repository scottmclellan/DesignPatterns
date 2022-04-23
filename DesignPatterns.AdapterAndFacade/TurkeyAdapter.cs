using DesignPatterns.Behaviours.Duck;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void About()
        {
            _turkey.Info();
            Console.WriteLine("Adapted to a Duck.");
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Swim()
        {
            Console.WriteLine("Turkey's can't swim!");
        }
    }
}
