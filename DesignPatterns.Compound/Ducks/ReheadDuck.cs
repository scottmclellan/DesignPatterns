using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class RedheadDuck: DuckBase,  IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObserver();
        }

        protected override IQuackObservable GetQuackObservable() => this;
    }
}
