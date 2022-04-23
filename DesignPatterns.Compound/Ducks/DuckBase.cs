using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public abstract class DuckBase
    {
        private Observable _observable;

        public DuckBase()
        {
            _observable = new Observable(GetQuackObservable());
        }

        public void NotifyObserver()
        {
            _observable.NotifyObserver();
        }

        protected abstract IQuackObservable GetQuackObservable();

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }
    }
}
