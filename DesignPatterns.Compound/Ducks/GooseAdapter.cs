using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class GooseAdapter : DuckBase, IQuackable
    {
        private readonly Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
            NotifyObserver();
        }

        protected override IQuackObservable GetQuackObservable() => this;
    }
}
