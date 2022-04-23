using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class DuckCall : DuckBase, IQuackable
    {      

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObserver();
        }    

        protected override IQuackObservable GetQuackObservable() => this;
    }
}
