using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class MallardDuck : DuckBase, IQuackable
    {          
        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObserver();
        }

        protected override IQuackObservable GetQuackObservable() => this;   
    }
}
