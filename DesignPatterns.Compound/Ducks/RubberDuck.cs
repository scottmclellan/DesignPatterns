using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class RubberDuck : DuckBase, IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObserver();
        }

        protected override IQuackObservable GetQuackObservable() => this;
    }
}
